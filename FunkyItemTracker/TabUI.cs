using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using FunkyItemTracker.ItemTrackerGUI;
using FunkyItemTracker.Objects;
using Zeta.Bot;
using Zeta.Game;
using Zeta.Game.Internals;

namespace FunkyItemTracker
{
	//Thanks to Rrrix for the Tab UI!
	//Taken from QuestTools

	class TabUi
	{
		private static Button _btnLogCharacterInventory, _btnLogCharacterEquipped, _btnLogCharacterStash, _btnShowGUI;

		private const string Indent3Hang = "                       ";

		internal static void InstallTab()
		{
			Application.Current.Dispatcher.Invoke(
				new Action(
					() =>
					{
						// 1st column x: 432
						// 2nd column x: 552
						// 3rd column x: 672

						// Y rows: 10, 33, 56, 79, 102

						_btnLogCharacterInventory = new Button
						{
							Width = 120,
							Height=20,
							HorizontalAlignment = HorizontalAlignment.Left,
							VerticalAlignment = VerticalAlignment.Top,
							Margin = new Thickness(3),
							Content = "Log Character Inventory"
						};
						_btnLogCharacterInventory.Click += BtnLogCharacterInventoryClick;

						_btnLogCharacterEquipped = new Button
						{
							Width = 120,
							Height = 20,
							HorizontalAlignment = HorizontalAlignment.Left,
							VerticalAlignment = VerticalAlignment.Top,
							Margin = new Thickness(3),
							Content = "Log Character Equipped"
						};
						_btnLogCharacterEquipped.Click += BtnLogCharacterEquippedClick;

						_btnLogCharacterStash = new Button
						{
							Width = 120,
							Height = 20,
							HorizontalAlignment = HorizontalAlignment.Left,
							VerticalAlignment = VerticalAlignment.Top,
							Margin = new Thickness(3),
							Content = "Log Character Stash"
						};
						_btnLogCharacterStash.Click += BtnLogCharacterStashClick;

						_btnShowGUI = new Button
						{
							Width = 120,
							Height = 20,
							HorizontalAlignment = HorizontalAlignment.Left,
							VerticalAlignment = VerticalAlignment.Top,
							Margin = new Thickness(3),
							Content = "Show GUI"
						};
						_btnShowGUI.Click += BtnShowGUIClick;

						UniformGrid uniformGrid = new UniformGrid
						{
							HorizontalAlignment = HorizontalAlignment.Stretch,
							VerticalAlignment = VerticalAlignment.Top,
							MaxHeight = 180,
						};

						uniformGrid.Children.Add(_btnShowGUI);
						uniformGrid.Children.Add(_btnLogCharacterInventory);
						uniformGrid.Children.Add(_btnLogCharacterEquipped);
						uniformGrid.Children.Add(_btnLogCharacterStash);

						_tabItem = new TabItem
						{
							Header = "ItemTracker",
							ToolTip = "Item Tracking Tool",
							Content = uniformGrid,
						};

						Window mainWindow = Application.Current.MainWindow;

						var tabs = mainWindow.FindName("tabControlMain") as TabControl;
						if (tabs == null)
							return;

						tabs.Items.Add(_tabItem);
					}
				)
			);
		}

		private static TabItem _tabItem;

		internal static void RemoveTab()
		{
			Application.Current.Dispatcher.Invoke(
				new Action(
					() =>
					{
						Window mainWindow = Application.Current.MainWindow;
						var tabs = mainWindow.FindName("tabControlMain") as TabControl;
						if (tabs == null)
							return;
						tabs.Items.Remove(_tabItem);

					}
				)
			);
		}

		private static bool IsGameValid()
		{
			if (BotMain.IsRunning)
			{
				ItemTracker.Logging.WarnFormat("Cannot Continue with Item Tracking Action -- Stop The Bot First!");
				return false;
			}

			if (!ZetaDia.IsInGame)
			{
				ItemTracker.Logging.WarnFormat("Cannot Continue with Item Tracking Action -- Join A Game First!");
				return false;
			}

			if (ZetaDia.IsLoadingWorld)
			{
				ItemTracker.Logging.WarnFormat("Cannot Continue with Item Tracking Action -- Wait For Loading to Complete!");
				return false;
			}

			if (ZetaDia.Me == null || ZetaDia.Me.CommonData == null)
			{
				ItemTracker.Logging.WarnFormat("Cannot Continue with Item Tracking Action -- Player Is Not Valid!");
				return false;
			}

			return true;
		}

		private static bool IsAccountValid()
		{
			//Init Account Details
			if (ItemTracker.AccountDetails == null)
				ItemTracker.AccountDetails = new CurrentAccountDetails();

			//Update Account Details
			if (!ItemTracker.AccountDetails.Update())
			{
				ItemTracker.Logging.WarnFormat("Cannot Continue with Item Tracking Action -- Failed to Update Account Details!");
				return false;
			}



			if (ItemTracker.CurrentAccount == null || ItemTracker.CurrentAccount.Name != ItemTracker.AccountDetails.BattleTag)
			{
				//Check for any previous existing files!
				if (!File.Exists(FolderPaths.ItemTrackerCurrentAccountFilePath))
				{
					//Create new Account Object
					ItemTracker.CurrentAccount = new Account(ItemTracker.AccountDetails.BattleTag);

					//Add Current Hero Info!
					ItemTracker.CurrentAccount.Characters.Add(new Character(ItemTracker.AccountDetails.Hero.Name, ItemTracker.AccountDetails.Hero.Level, ItemTracker.AccountDetails.Hero.Class));

					//Create File!
					Account.SerializeToXML(ItemTracker.CurrentAccount, FolderPaths.ItemTrackerCurrentAccountFilePath);
				}
				else
				{
					//Load File!
					ItemTracker.CurrentAccount = Account.DeserializeFromXML(FolderPaths.ItemTrackerCurrentAccountFilePath);
				}

			}

			if (!ItemTracker.CurrentAccount.Characters.Contains(ItemTracker.AccountDetails.Hero))
			{
				//Add Current Hero Info!
				ItemTracker.CurrentAccount.Characters.Add(new Character(ItemTracker.AccountDetails.Hero.Name, ItemTracker.AccountDetails.Hero.Level, ItemTracker.AccountDetails.Hero.Class));

				//Update File!
				Account.SerializeToXML(ItemTracker.CurrentAccount, FolderPaths.ItemTrackerCurrentAccountFilePath);
			}


			return true;
		}

		private static void BtnShowGUIClick(object sender, RoutedEventArgs e)
		{
			frmItemTracker.thisForm = new frmItemTracker();
			frmItemTracker.thisForm.ShowDialog();
		}
		private static void BtnLogCharacterInventoryClick(object sender, RoutedEventArgs e)
		{
			MessageBoxResult confirmResult = MessageBox.Show("Do you wish to log Backpack Items?","Confirm Item Logging", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
			if (confirmResult != MessageBoxResult.Yes)
				return;

			ZetaDia.Memory.ClearCache();
			ZetaDia.Actors.Update();

			if (!IsGameValid()) return;
			if (!IsAccountValid()) return;

			int characterIndex = ItemTracker.CurrentAccount.Characters.IndexOf(ItemTracker.AccountDetails.Hero);
			ItemTracker.CurrentAccount.Characters[characterIndex].InventoryItems.Clear();

			foreach (var item in ZetaDia.Me.Inventory.Backpack)
			{
				try
				{
					ItemTracker.CurrentAccount.Characters[characterIndex].InventoryItems.Add(new TrackedItem(item));
				}
				catch (Exception)
				{

				}
			}

			//Update File!
			Account.SerializeToXML(ItemTracker.CurrentAccount, FolderPaths.ItemTrackerCurrentAccountFilePath);
			ItemTracker.Logging.WarnFormat("Logging Character Inventory Completed!");
		}
		private static void BtnLogCharacterEquippedClick(object sender, RoutedEventArgs e)
		{
			MessageBoxResult confirmResult = MessageBox.Show("Do you wish to log Equipped Items?", "Confirm Item Logging", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
			if (confirmResult != MessageBoxResult.Yes)
				return;

			ZetaDia.Memory.ClearCache();
			ZetaDia.Actors.Update();

			if (!IsGameValid()) return;
			if (!IsAccountValid()) return;

			int characterIndex = ItemTracker.CurrentAccount.Characters.IndexOf(ItemTracker.AccountDetails.Hero);
			ItemTracker.CurrentAccount.Characters[characterIndex].EquippedItems.Clear();

			foreach (var item in ZetaDia.Me.Inventory.Equipped)
			{
				try
				{
					ItemTracker.CurrentAccount.Characters[characterIndex].EquippedItems.Add(new TrackedItem(item));
				}
				catch (Exception)
				{

				}
			}

			//Update File!
			Account.SerializeToXML(ItemTracker.CurrentAccount, FolderPaths.ItemTrackerCurrentAccountFilePath);
			ItemTracker.Logging.WarnFormat("Logging Character Equipment Completed!");
		}
		private static void BtnLogCharacterStashClick(object sender, RoutedEventArgs e)
		{
			MessageBoxResult confirmResult = MessageBox.Show("This may take up to a minute or longer to complete, do you wish to continue?", "Confirm Item Logging", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.Cancel);
			if (confirmResult != MessageBoxResult.Yes)
				return;

			ZetaDia.Memory.ClearCache();
			ZetaDia.Actors.Update();

			if (!IsGameValid()) return;
			//Check Stash Window is Visible!
			if (!UIElements.StashWindow.IsVisible)
			{
				ItemTracker.Logging.WarnFormat("Cannot Continue with Item Tracking Action -- Make sure Stash Window Is Visible!");
				return;
			}
			if (!IsAccountValid()) return;


		
			List<TrackedItem> newItemList = new List<TrackedItem>();

			foreach (var item in ZetaDia.Me.Inventory.StashItems)
			{
				try
				{
					newItemList.Add(new TrackedItem(item));
				}
				catch (Exception)
				{

				}
			}

			ItemTracker.CurrentAccount.StashedItems = new List<TrackedItem>(newItemList);

			//Update File!
			Account.SerializeToXML(ItemTracker.CurrentAccount, FolderPaths.ItemTrackerCurrentAccountFilePath);

			ItemTracker.Logging.WarnFormat("Logging Character Stash Completed!");
		}
	}
}

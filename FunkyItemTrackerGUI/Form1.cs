using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunkyItemTrackerGUI.Objects;

namespace FunkyItemTrackerGUI
{
	public partial class Form1 : Form
	{
		internal static Form1 thisForm;

		public Form1()
		{
			InitializeComponent();
			
		}

		internal static Account CurrentAccount;

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Set filter options and filter index.
			openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;

			var result = openFileDialog1.ShowDialog();
			if (result==DialogResult.OK)
			{
				CurrentAccount = Account.DeserializeFromXML(openFileDialog1.FileName);
				foreach (var i in CurrentAccount.Characters)
				{
					CharacterSlot cs = new CharacterSlot(i);
					cs.OnMouseClicked += CharacterSlot_MouseClick;
					flowLayoutPanel1.Controls.Add(cs);
				}
			}
		}

		private void CharacterSlot_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Right)
			{
				contextMenuCharacter.Show(Cursor.Position);
				return;
			}

			CharacterSlot senderObj = (CharacterSlot)sender;
			Character senderChar=senderObj.OChar;
			int index=CurrentAccount.Characters.IndexOf(senderChar);

			panel_Items.Controls.Clear();
			InventoryControl newInv = new InventoryControl(senderChar.InventoryItems, 10, 6);
			newInv.OnItemSelected += OnItemSelected;
			newInv.Dock=DockStyle.Fill;

			panel_Items.Controls.Add(newInv);
			//MessageBox.Show(CurrentAccount.Characters[index].InventoryItems.Count.ToString());
		}

		internal static TrackedItem selectedItem = null;
		private void OnItemSelected(TrackedItem i)
		{
			selectedItem = i;
			if (selectedItem != null)
				panel_ItemInfo.Invalidate();
		}
		private static FontFamily fontFamily = new FontFamily("Arial");
		private static readonly Font font_ItemName = new Font(fontFamily,16,FontStyle.Bold,GraphicsUnit.Pixel);
		private static readonly Font font_SNO = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);
		private static readonly Font font_ItemMain_DPSArmor = new Font(fontFamily, 18, FontStyle.Bold, GraphicsUnit.Pixel);
		private static readonly Font font_ItemStat = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);

		private void panel_ItemInfo_Paint(object sender, PaintEventArgs e)
		{
			base.OnPaint(e);

			if (selectedItem != null)
			{
				Graphics g = e.Graphics;

				//Name
				g.DrawString(selectedItem.Name, font_ItemName, selectedItem.GetBrushColor(), 0, 0);
				//SNO
				g.DrawString("(" + selectedItem.SNO.ToString() + ")", font_SNO, Brushes.PeachPuff, 0, 17);
				//Level and Type
				g.DrawString("(" + selectedItem.Level + ", " + selectedItem.Type.ToString() + ")", font_SNO, Brushes.PeachPuff, 0, 30);

				//Armor?
				if (selectedItem.ItemStats.Armor > 0)
				{
					g.DrawString("Armor " + selectedItem.ItemStats.ArmorTotal.ToString(), font_ItemMain_DPSArmor, Brushes.LightGray, 0, 100);
					//g.DrawString(selectedItem.ItemStats.ArmorTotal.ToString(), font_ItemMain_DPSArmor, Brushes.LightGray, 0, 125);

					//Block?
					if (selectedItem.ItemStats.BlockChance > 0)
					{
						g.DrawString("Block " + selectedItem.ItemStats.BlockChance.ToString() + "%", font_ItemMain_DPSArmor, Brushes.LightGray, 0, 130);
					}
				}
				else if (selectedItem.ItemStats.WeaponDamagePerSecond > 0)
				{
					g.DrawString("DPS", font_ItemMain_DPSArmor, Brushes.LightGray, 0, 100);
					g.DrawString(selectedItem.ItemStats.WeaponDamagePerSecond.ToString(), font_ItemMain_DPSArmor, Brushes.LightGray, 0, 125);
				}

				int y = 200;
				List<string> statsList = selectedItem.ItemStats.GetPrimaryStatStrings();
				if (statsList.Count > 0)
				{
					g.DrawString("Primary", font_ItemStat, Brushes.DeepSkyBlue, 0, 185);

					foreach (var s in statsList)
					{
						g.DrawString(s, font_ItemStat, Brushes.DeepSkyBlue, 0, y);
						y += 15;
					}

					y += 50;
				}

				statsList = selectedItem.ItemStats.GetSecondaryStatStrings();
				if (statsList.Count > 0)
				{
					g.DrawString("Secondary", font_ItemStat, Brushes.DeepSkyBlue, 0, y);
					y += 15;

					foreach (var s in statsList)
					{
						g.DrawString(s, font_ItemStat, Brushes.DeepSkyBlue, 0, y);
						y += 15;
					}
				}

			}
		}

		private void showStashToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel_Items.Controls.Clear();
			StashContainerControl newStash = new StashContainerControl(CurrentAccount.StashedItems);
			//InventoryControl newInv = new InventoryControl(CurrentAccount.StashedItems, 7, 10);
			//newInv.OnItemSelected += OnItemSelected;
			//newInv.Dock = DockStyle.Fill;

			panel_Items.Controls.Add(newStash);
		}
	}
}

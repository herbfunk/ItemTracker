using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FunkyItemTracker.Objects;

namespace FunkyItemTracker.ItemTrackerGUI.Controls
{
	public partial class ItemPreviewControl : UserControl
	{
		internal TrackedItem CurrentItem = null;
		public ItemPreviewControl()
		{
			//Dock = DockStyle.Right;
			InitializeComponent();
		}

		private static readonly FontFamily fontFamily = new FontFamily("Arial");
		private readonly Font font_ItemName = new Font(fontFamily, 18, FontStyle.Bold, GraphicsUnit.Pixel);
		private readonly Font font_SNO = new Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Pixel);
		private readonly Font font_ItemMain_DPSArmor = new Font(fontFamily, 16, FontStyle.Bold, GraphicsUnit.Pixel);
		private readonly Font font_ItemStat = new Font(fontFamily, 12, FontStyle.Bold, GraphicsUnit.Pixel);

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Graphics g = e.Graphics;
			
			if (CurrentItem != null)
			{
				float cur_y = 0;

				//Name
				g.DrawString(CurrentItem.Name, font_ItemName, CurrentItem.GetBrushColor(), 0, cur_y);
				cur_y += font_SNO.Size * 2;

				
				g.DrawString("Type: " + CurrentItem.Type, font_SNO, Brushes.PeachPuff, 0, cur_y);
				cur_y += font_SNO.Size + 2;

				//SNO, Level and Type
				g.DrawString("(SNO: " + CurrentItem.SNO + ") (BalanceID: " + CurrentItem.BalanceId + ")", font_SNO, Brushes.PeachPuff, 0, cur_y);
				cur_y += font_SNO.Size * 2;

				if (CurrentItem.MaxStackCount>0)
				{
					g.DrawString(String.Format("Stack Quanity {0} / Max Stack Quanity {1}", CurrentItem.StackQuantity, CurrentItem.MaxStackCount), font_SNO, Brushes.PeachPuff, 0, cur_y);
					cur_y += font_SNO.Size * 2;
					g.DrawString("Type: " + CurrentItem.Type, font_SNO, Brushes.PeachPuff, 0, cur_y);
					cur_y += font_SNO.Size * 2;
					g.DrawString("Level: " + CurrentItem.Level, font_SNO, Brushes.PeachPuff, 0, cur_y);
					return;
				}

				//
				//g.DrawString("(" + CurrentItem.Level + ", " + CurrentItem.Type.ToString() + ")", font_SNO, Brushes.PeachPuff, 0, 30);

				//Armor?
				if (CurrentItem.ItemStats.Armor > 0)
				{
					g.DrawString("Armor " + CurrentItem.ItemStats.ArmorTotal.ToString(), font_ItemMain_DPSArmor, Brushes.LightGray, 0, cur_y);
					cur_y += font_ItemMain_DPSArmor.Size+1;

					//g.DrawString(CurrentItem.ItemStats.ArmorTotal.ToString(), font_ItemMain_DPSArmor, Brushes.LightGray, 0, 125);

					//Block?
					if (CurrentItem.ItemStats.BlockChance > 0)
					{
						g.DrawString("Block " + CurrentItem.ItemStats.BlockChance.ToString() + "%", font_ItemMain_DPSArmor, Brushes.LightGray, 0, cur_y);
						cur_y += font_ItemMain_DPSArmor.Size * 2;
					}
					else
						cur_y += font_ItemMain_DPSArmor.Size;
					
				}
				else if (CurrentItem.ItemStats.WeaponDamagePerSecond > 0)
				{
					g.DrawString("DPS: " + CurrentItem.ItemStats.WeaponDamagePerSecond.ToString(), font_ItemMain_DPSArmor, Brushes.LightGray, 0, cur_y);
					cur_y += font_ItemMain_DPSArmor.Size + 1;

					if (CurrentItem.ItemStats.WeaponAttacksPerSecond>0)
					{
						g.DrawString(CurrentItem.ItemStats.WeaponAttacksPerSecond + " Attack Speed", font_ItemMain_DPSArmor, Brushes.LightGray, 0, cur_y);
						cur_y += font_ItemMain_DPSArmor.Size * 2;
					}
					else
						cur_y += font_ItemMain_DPSArmor.Size;
				}

				
				List<string> statsList = CurrentItem.ItemStats.GetPrimaryStatStrings();

				if (statsList.Count > 0)
				{
					g.DrawString("Primary", font_ItemStat, Brushes.DeepSkyBlue, 0, cur_y);
					cur_y += font_ItemStat.Size+1;

					foreach (var s in statsList)
					{
						g.DrawString(s, font_ItemStat, Brushes.DeepSkyBlue, 0, cur_y);
						cur_y += font_ItemStat.Size + 1;
					}

					cur_y += font_ItemStat.Size * 2;
				}

				statsList = CurrentItem.ItemStats.GetSecondaryStatStrings();
				if (statsList.Count > 0)
				{
					g.DrawString("Secondary", font_ItemStat, Brushes.DeepSkyBlue, 0, cur_y);
					cur_y += font_ItemStat.Size + 1;

					foreach (var s in statsList)
					{
						g.DrawString(s, font_ItemStat, Brushes.DeepSkyBlue, 0, cur_y);
						cur_y += font_ItemStat.Size + 1;
					}
				}

				cur_y += font_SNO.Size * 2;
				g.DrawString("Level: " + CurrentItem.Level, font_SNO, Brushes.PeachPuff, 0, cur_y);

			}
			
		}

	}
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FunkyItemTracker.Objects;
using Zeta.Game;

namespace FunkyItemTracker.ItemTrackerGUI.Controls
{
	public partial class EquipmentControl : UserControl
	{
		private RectangleF Head,Shoulder,Gloves,Bracers,Belt,Pants,Boots,Weapon,Offhand,Chest,LeftRing,RightRing,Neck;
		private Dictionary<RectangleF, InventorySlot> equippedRectangles = new Dictionary<RectangleF, InventorySlot>();
		private Dictionary<RectangleF, TrackedItem> rectTrackedItems = new Dictionary<RectangleF, TrackedItem>();

		private readonly List<TrackedItem> EquippedItems;

		public EquipmentControl(List<TrackedItem> equippedItems)
		{
			EquippedItems=equippedItems;
			Dock = DockStyle.Fill;
			InitializeComponent();
			
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			string pathloc = FolderPaths.ItemTrackerPluginGUIFolderPath;
			Graphics g = e.Graphics;

			using (Pen outline = new Pen(Brushes.Black, 1f))
			{
				foreach (var rect in equippedRectangles.Keys)
				{
					g.FillRectangle(Brushes.LightGray, rect);
					g.DrawRectangle(outline, rect.X, rect.Y, rect.Width, rect.Height);
				}
			}

			rectTrackedItems.Clear();
			foreach (var item in EquippedItems)
			{
				if (!equippedRectangles.Values.Contains(item.InventorySlot)) continue;
				var keyvalue = equippedRectangles.First(er => er.Value == item.InventorySlot).Key;

				Bitmap bpItemIcon = new Bitmap(Path.Combine(pathloc, "Images", "Items", item.GetImageIcon()));
				g.DrawImage(bpItemIcon, keyvalue);

				//add to collection to track the item
				rectTrackedItems.Add(keyvalue, item);
			}
		}

		private void InitRectangles()
		{
			float widthF=(float)Width;
			float heightF=(float)Height;

			Head=new RectangleF(widthF*0.38f, 0f, widthF*0.22f, heightF*0.15f);
			Shoulder=new RectangleF(widthF*0.10f, heightF*0.06f, widthF*0.22f, heightF*0.22f);
			Gloves=new RectangleF(0f, heightF*0.3f, widthF*0.22f, heightF*0.22f);
			Bracers=new RectangleF(widthF*0.77f, heightF*0.3f, widthF*0.22f, heightF*0.22f);
			Belt=new RectangleF(widthF*0.35f, heightF*0.46f, widthF*0.30f, heightF*0.08f);
			Pants=new RectangleF(widthF*0.38f, heightF*0.55f, widthF*0.22f, heightF*0.22f);
			Boots=new RectangleF(widthF*0.38f, heightF*0.78f, widthF*0.22f, heightF*0.22f);
			Weapon=new RectangleF(0f, heightF*0.67f, widthF*0.22f, heightF*0.30f);
			Offhand=new RectangleF(widthF*0.77f, heightF*0.67f, widthF*0.22f, heightF*0.30f);
			Chest=new RectangleF(widthF*0.35f, heightF*0.16f, widthF*0.30f, heightF*0.30f);
			LeftRing=new RectangleF(widthF*0.04f, heightF*0.55f, widthF*0.15f, heightF*0.10f);
			RightRing=new RectangleF(widthF*0.81f, heightF*0.55f, widthF*0.15f, heightF*0.10f);
			Neck = new RectangleF(widthF * 0.68f, heightF * 0.10f, widthF * 0.18f, heightF * 0.13f);

			equippedRectangles.Clear();
			equippedRectangles.Add(Head, InventorySlot.Head);
			equippedRectangles.Add(Shoulder, InventorySlot.Shoulders);
			equippedRectangles.Add(Gloves, InventorySlot.Hands);
			equippedRectangles.Add(Bracers, InventorySlot.Bracers);
			equippedRectangles.Add(Belt, InventorySlot.Waist);
			equippedRectangles.Add(Pants, InventorySlot.Legs);
			equippedRectangles.Add(Boots, InventorySlot.Feet);
			equippedRectangles.Add(Weapon, InventorySlot.LeftHand);
			equippedRectangles.Add(Offhand, InventorySlot.RightHand);
			equippedRectangles.Add(Chest, InventorySlot.Torso);
			equippedRectangles.Add(LeftRing, InventorySlot.LeftFinger);
			equippedRectangles.Add(RightRing, InventorySlot.RightFinger);
			equippedRectangles.Add(Neck, InventorySlot.Neck);
		}

		private void EquipmentControl_Resize(object sender, EventArgs e)
		{
			InitRectangles();
		}

		public delegate void ItemSelected(TrackedItem i);
		public event ItemSelected OnItemSelected;
		private TrackedItem LastSelectedItem = null;
		private void EquipmentControl_MouseClick(object sender, MouseEventArgs e)
		{
			foreach (var rect in rectTrackedItems.Keys)
			{
				if (rect.Contains(e.Location))
				{
					LastSelectedItem = rectTrackedItems[rect];
					if (OnItemSelected != null) OnItemSelected(LastSelectedItem);
				}
			}
		}
	}
}

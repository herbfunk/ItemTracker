using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunkyItemTrackerGUI.Enums;
using FunkyItemTrackerGUI.Objects;

namespace FunkyItemTrackerGUI.Controls
{
	public partial class EquipmentControl : UserControl
	{
		private RectangleF Head,Shoulder,Gloves,Bracers,Belt,Pants,Boots,Weapon,Offhand,Chest,LeftRing,RightRing,Neck;
		private Dictionary<RectangleF, TrackerInventorySlot> equippedRectangles = new Dictionary<RectangleF, TrackerInventorySlot>();
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

			string pathloc = Paths.RootDirectory;
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
			equippedRectangles.Add(Head, TrackerInventorySlot.Head);
			equippedRectangles.Add(Shoulder, TrackerInventorySlot.Shoulders);
			equippedRectangles.Add(Gloves, TrackerInventorySlot.Hands);
			equippedRectangles.Add(Bracers, TrackerInventorySlot.Bracers);
			equippedRectangles.Add(Belt, TrackerInventorySlot.Waist);
			equippedRectangles.Add(Pants, TrackerInventorySlot.Legs);
			equippedRectangles.Add(Boots, TrackerInventorySlot.Feet);
			equippedRectangles.Add(Weapon, TrackerInventorySlot.LeftHand);
			equippedRectangles.Add(Offhand, TrackerInventorySlot.RightHand);
			equippedRectangles.Add(Chest, TrackerInventorySlot.Torso);
			equippedRectangles.Add(LeftRing, TrackerInventorySlot.LeftFinger);
			equippedRectangles.Add(RightRing, TrackerInventorySlot.RightFinger);
			equippedRectangles.Add(Neck, TrackerInventorySlot.Neck);
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

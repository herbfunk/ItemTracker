using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FunkyItemTrackerGUI.Objects;

namespace FunkyItemTrackerGUI.Controls
{
	public partial class StashContainerControl : UserControl
	{
		public delegate void ItemSelected(TrackedItem i);
		public event InventoryControl.ItemSelected OnItemSelected;
		private void ItemSelectedHandler(TrackedItem i)
		{
			if (OnItemSelected != null) OnItemSelected(i);
		}

		private readonly Dictionary<int, List<TrackedItem>> StashItems;  
		public StashContainerControl(List<TrackedItem> Items)
		{
			InitializeComponent();
			StashItems = new Dictionary<int, List<TrackedItem>>();

			foreach (var i in Items)
			{
				if (i.invRow<=9)
				{
					if (!StashItems.ContainsKey(0))
						StashItems.Add(0, new List<TrackedItem>());

					StashItems[0].Add(i);
				}
				else if (i.invRow <= 19)
				{
					if (!StashItems.ContainsKey(1))
						StashItems.Add(1, new List<TrackedItem>());

					StashItems[1].Add(i);
				}
				else if (i.invRow <= 29)
				{
					if (!StashItems.ContainsKey(2))
						StashItems.Add(2, new List<TrackedItem>());

					StashItems[2].Add(i);
				}
				else if (i.invRow <= 39)
				{
					if (!StashItems.ContainsKey(3))
						StashItems.Add(3, new List<TrackedItem>());

					StashItems[3].Add(i);
				}
			}

		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		}

		private void panel_StashButtons_Paint(object sender, PaintEventArgs e)
		{
			base.OnPaint(e);
			string pathloc = Paths.RootDirectory;
			Bitmap bpStashButton = new Bitmap(Path.Combine(pathloc, "Images", "StashButton.png"));
			int _height = panel_StashButtons.Height / 4;

			Graphics g = e.Graphics;

			for (int i = 0; i < 4; i++)
			{
				g.DrawImage(bpStashButton, 0, i * _height, 54, _height);
			}
		}

		private void panel_StashButtons_MouseClick(object sender, MouseEventArgs e)
		{
			int _height = panel_StashButtons.Height / 4;
			int index=e.Y / _height;
			if (index < 0) index = 0;

			panel_Items.Controls.Clear();
			InventoryControl newInv=new InventoryControl(StashItems[index], 7, 10, index);
			newInv.OnItemSelected += ItemSelectedHandler;
			panel_Items.Controls.Add(newInv);
		}
	}
}

using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FunkyItemTrackerGUI.Objects;

namespace FunkyItemTrackerGUI.Controls
{
	public partial class InventoryControl : UserControl
	{
		private readonly int ColumnCount, RowCount, IndexReduction;
		private List<TrackedItem> Items;
		private Dictionary<int, TrackedItem> ItemInventory=new Dictionary<int, TrackedItem>();
		private int width_size
		{
			get
			{
				return Width / ColumnCount;
			}
		}
		private int height_size
		{
			get
			{
				return Height / RowCount;
			}
		}
		private int row_reduction
		{
			get
			{
				return IndexReduction * 10;
			}
		}
		private List<Rectangle> HighlightedSquares = new List<Rectangle>();
 
		public InventoryControl(List<TrackedItem> items, int colCount, int rowCount, int indexReduction=0)
		{
			Dock = DockStyle.Fill;
			InitializeComponent();

			ColumnCount = colCount;
			RowCount = rowCount;
			IndexReduction = indexReduction;

			Items = new List<TrackedItem>();
			foreach (var item in items)
			{
				if (item.invRow - row_reduction > rowCount) continue;

				ItemInventory.Add(((item.invRow - row_reduction) * 10) + item.invCol, item);
				if (item.DetermineIsTwoSlot()) ItemInventory.Add((((item.invRow - row_reduction) + 1) * 10) + item.invCol, item);
				Items.Add(item);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			string pathloc = Paths.RootDirectory;
			Bitmap bpInvSquare = new Bitmap(Path.Combine(pathloc, "Images", "InvSquare.png"));

			Graphics g = e.Graphics;

			//Draw Graphics!
			for (int y = 0; y < RowCount; y++)
			{
				for (int x = 0; x < ColumnCount; x++)
				{
					g.DrawImage(bpInvSquare, x * width_size, y * height_size, width_size, height_size);
				}
			}


			//Draw Items!
			foreach (var item in Items)
			{
				Bitmap bpItemIcon = new Bitmap(Path.Combine(pathloc, "Images", "Items", item.GetImageIcon()));

				bool istwoslot = item.DetermineIsTwoSlot();

				g.DrawImage(bpItemIcon, item.invCol * width_size, (item.invRow - row_reduction) * height_size, width_size, istwoslot ? height_size * 2 : height_size);
			}

			//Draw Highlighted Squares
			foreach (var r in HighlightedSquares)
			{
				using (Pen borderPen = new Pen(Brushes.WhiteSmoke, 2))
				{
					g.DrawRectangle(borderPen, r);
				}
			}



		}

		private void InventoryControl_MouseMove(object sender, MouseEventArgs e)
		{
			int row = e.Y / height_size;
			int col = e.X / width_size;
			if (row < 0) row = 0;
			if (col < 0) col = 0;
			if (col > 9) col = 9;

			int index = (row * 10) + col;
			if (ItemInventory.ContainsKey(index))
			{
				//MessageBox.Show(ItemInventory[index].Name);
			}
		}

		public delegate void ItemSelected(TrackedItem i);
		public event ItemSelected OnItemSelected;
		private TrackedItem LastSelectedItem = null;
		private void InventoryControl_MouseClick(object sender, MouseEventArgs e)
		{
			int row = e.Y / height_size;
			int col = e.X / width_size;
			if (row < 0) row = 0;
			if (col < 0) col = 0;
			if (col > 9) col = 9;
			int index = (row * 10) + col;
			if (ItemInventory.ContainsKey(index))
			{
				TrackedItem item = ItemInventory[index];
				if (LastSelectedItem==null || item!=LastSelectedItem)
				{
					LastSelectedItem = item;

					//Clear our Highlighted Rectangles
					HighlightedSquares.Clear();

					//Add new Rectangle to Highlighted Collection
					Rectangle r = new Rectangle(item.invCol * width_size, (item.invRow - row_reduction) * height_size, width_size, item.DetermineIsTwoSlot() ? height_size * 2 : height_size);
					HighlightedSquares.Add(r);

					//Raise Event!
					if (OnItemSelected != null) OnItemSelected(item);

					//Invalidate (force repaint)
					Invalidate();
				}

				

				if (e.Button == MouseButtons.Right)
					itemMenu.Show(MousePosition);
			}
		}

		private void copyItemStringToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (LastSelectedItem!=null)
			{
				Clipboard.SetText(LastSelectedItem.ReturnItemString());
			}
		}
	}
}

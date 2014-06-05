using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunkyItemTrackerGUI.Enums;
using FunkyItemTrackerGUI.Objects;

namespace FunkyItemTrackerGUI
{
	public partial class CharacterSlot : UserControl
	{
		internal readonly Character OChar;

		public CharacterSlot(Character c)
		{
			InitializeComponent();

			OChar = c;
			lbl_Name.Text = c.Name;

			string pathloc = Paths.RootDirectory;
			string iconname = c.GetImageIcon();

			try
			{
				pb_Image.Image = new Bitmap(Path.Combine(pathloc, "Images", "Icons", iconname));
				pb_Image.Dock=DockStyle.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error creating image!");
			}
			
		}

		public delegate void _MouseClick(object sender, MouseEventArgs e);
		public event _MouseClick OnMouseClicked;

		private void CharacterSlot_MouseClick(object sender, MouseEventArgs e)
		{
			Focus();
			BackColor = Color.SteelBlue;

			if (OnMouseClicked!=null)
				OnMouseClicked(this, e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		}

		private void CharacterSlot_Leave(object sender, EventArgs e)
		{
			BackColor = Color.Transparent;
		}

	
	}
}

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
		protected bool Equals(CharacterSlot other)
		{
			return Equals(OChar, other.OChar);
		}

		public override int GetHashCode()
		{
			return (OChar != null ? OChar.GetHashCode() : 0);
		}

		internal readonly Character OChar;
		internal bool IsHighlighted = false;

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

			if (OnMouseClicked!=null) OnMouseClicked(this, e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
		}

		private void CharacterSlot_Leave(object sender, EventArgs e)
		{
			//if (!IsHighlighted) BackColor = Color.Transparent;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((CharacterSlot) obj);
		}
	}
}

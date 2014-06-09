using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FunkyItemTrackerGUI.Controls;
using FunkyItemTrackerGUI.Objects;

namespace FunkyItemTrackerGUI
{
	public partial class frmItemTracker : Form
	{
		internal static frmItemTracker thisForm;

		public frmItemTracker()
		{
			InitializeComponent();
			LoadCharacterData(@"C:\Users\mault\Desktop\db_beta\ItemTracker\bilbo#1690.xml");
		}

		internal static Account CurrentAccount;
		internal static List<TrackedItem> AllItems;
 
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Set filter options and filter index.
			openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;

			var result = openFileDialog1.ShowDialog();
			if (result==DialogResult.OK)
			{
				LoadCharacterData(openFileDialog1.FileName);
			}
		}

		private void LoadCharacterData(string File)
		{
			CurrentAccount = Account.DeserializeFromXML(File);
			AllItems = new List<TrackedItem>(CurrentAccount.StashedItems);

			foreach (var i in CurrentAccount.Characters)
			{
				CharacterSlot cs = new CharacterSlot(i);
				AllItems.AddRange(i.InventoryItems);
				AllItems.AddRange(i.EquippedItems);

				cs.OnMouseClicked += CharacterSlot_MouseClick;
				flowlayout_Characters.Controls.Add(cs);
			}

			AllItems = AllItems.OrderBy(i => i.Name).ToList();
			label1.Text = "Total Items: " + AllItems.Count.ToString();
		}

		private Character lastSelectedCharacterSlot = null;
		private void CharacterSlot_MouseClick(object sender, MouseEventArgs e)
		{
			CharacterSlot senderObj = (CharacterSlot)sender;
			Character senderChar = senderObj.OChar;
			int index = CurrentAccount.Characters.IndexOf(senderChar);

			lastSelectedCharacterSlot = CurrentAccount.Characters[index];

			if (e.Button==MouseButtons.Right)
			{
				contextMenuCharacter.Show(Cursor.Position);
				return;
			}


			//Ignore if already highlighted!
			if (senderObj.IsHighlighted)return;

			for (int i = 0; i < flowlayout_Characters.Controls.Count; i++)
			{
				CharacterSlot obj=((CharacterSlot)flowlayout_Characters.Controls[i]);
				if (obj.Equals(senderObj))
				{
					obj.IsHighlighted = true;
					obj.Invalidate();
					continue;
				}

				obj.IsHighlighted = false;
				obj.BackColor = Color.Transparent;
				obj.Invalidate();
			}

			



			panel_Items.Controls.Clear();
			InventoryControl newInv = new InventoryControl(senderChar.InventoryItems, 10, 6);
			newInv.OnItemSelected += OnItemSelected;
			newInv.Dock=DockStyle.Fill;
			panel_Items.Controls.Add(newInv);

			//Clear Item Viewer
			itemViewer.CurrentItem = null;
			itemViewer.Invalidate();

			//MessageBox.Show(CurrentAccount.Characters[index].InventoryItems.Count.ToString());
		}

		
		internal void OnItemSelected(TrackedItem i)
		{
			itemViewer.CurrentItem = i;
			itemViewer.Invalidate();
		}

		private void showStashToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel_Items.Controls.Clear();
			StashContainerControl newStash = new StashContainerControl(CurrentAccount.StashedItems);
			newStash.Dock=DockStyle.Fill;
			newStash.OnItemSelected+=OnItemSelected;

			panel_Items.Controls.Add(newStash);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!groupBox2.Visible)
				groupBox2.Show();
			else
				groupBox2.Hide();
			
			groupBox1.Invalidate();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == String.Empty) return;

			string lower = textBox1.Text.ToLower();

			List<TrackedItem> foundItems = new List<TrackedItem>();
			foreach (var i in AllItems)
			{
				if (i.Name.ToLower().Contains(lower))
					foundItems.Add(i);
			}

			MessageBox.Show("Found a total of " + foundItems.Count.ToString() + " items");
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			flowlayout_Characters.Invalidate();
			itemViewer.Invalidate();
			panel_Items.Refresh();
		}

		private void showEquippedToolStripMenuItem_Click(object sender, EventArgs e)
		{

			panel_Items.Controls.Clear();
			EquipmentControl newInv = new EquipmentControl(lastSelectedCharacterSlot.EquippedItems);
			newInv.OnItemSelected += OnItemSelected;
			newInv.Dock = DockStyle.Fill;
			panel_Items.Controls.Add(newInv);

			//Clear Item Viewer
			itemViewer.CurrentItem = null;
			itemViewer.Invalidate();
		}
	}
}

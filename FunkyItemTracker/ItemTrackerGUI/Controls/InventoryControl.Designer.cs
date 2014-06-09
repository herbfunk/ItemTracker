using System.Windows.Forms;

namespace FunkyItemTracker.ItemTrackerGUI.Controls
{
	partial class InventoryControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.itemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyItemStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// itemMenu
			// 
			this.itemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyItemStringToolStripMenuItem});
			this.itemMenu.Name = "itemMenu";
			this.itemMenu.Size = new System.Drawing.Size(156, 48);
			// 
			// copyItemStringToolStripMenuItem
			// 
			this.copyItemStringToolStripMenuItem.Name = "copyItemStringToolStripMenuItem";
			this.copyItemStringToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.copyItemStringToolStripMenuItem.Text = "Copy Item String";
			this.copyItemStringToolStripMenuItem.Click += new System.EventHandler(this.copyItemStringToolStripMenuItem_Click);
			// 
			// InventoryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.DoubleBuffered = true;
			this.Name = "InventoryControl";
			this.Size = new System.Drawing.Size(0, 24);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InventoryControl_MouseClick);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InventoryControl_MouseMove);
			this.itemMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private ContextMenuStrip itemMenu;

		#endregion
		private ToolStripMenuItem copyItemStringToolStripMenuItem;

	}
}

using System.Windows.Forms;

namespace FunkyItemTracker.ItemTrackerGUI.Controls
{
	partial class StashContainerControl
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
			this.panel_StashButtons = new System.Windows.Forms.Panel();
			this.panel_Items = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panel_StashButtons
			// 
			this.panel_StashButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_StashButtons.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_StashButtons.Location = new System.Drawing.Point(0, 0);
			this.panel_StashButtons.Name = "panel_StashButtons";
			this.panel_StashButtons.Size = new System.Drawing.Size(54, 666);
			this.panel_StashButtons.TabIndex = 0;
			this.panel_StashButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_StashButtons_Paint);
			this.panel_StashButtons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_StashButtons_MouseClick);
			// 
			// panel_Items
			// 
			this.panel_Items.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Items.Location = new System.Drawing.Point(54, 0);
			this.panel_Items.Name = "panel_Items";
			this.panel_Items.Size = new System.Drawing.Size(819, 666);
			this.panel_Items.TabIndex = 1;
			// 
			// StashContainerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panel_Items);
			this.Controls.Add(this.panel_StashButtons);
			this.Name = "StashContainerControl";
			this.Size = new System.Drawing.Size(873, 666);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_StashButtons;
		private Panel panel_Items;
	}
}

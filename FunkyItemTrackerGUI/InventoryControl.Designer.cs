using System.Windows.Forms;

namespace FunkyItemTrackerGUI
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
			this.SuspendLayout();
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
			this.Size = new System.Drawing.Size(1536, 666);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InventoryControl_MouseClick);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InventoryControl_MouseMove);
			this.ResumeLayout(false);

		}

		#endregion

	}
}

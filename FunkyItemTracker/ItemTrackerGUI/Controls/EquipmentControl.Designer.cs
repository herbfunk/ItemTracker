﻿namespace FunkyItemTracker.ItemTrackerGUI.Controls
{
	partial class EquipmentControl
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
			// EquipmentControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Name = "EquipmentControl";
			this.Size = new System.Drawing.Size(0, 0);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EquipmentControl_MouseClick);
			this.Resize += new System.EventHandler(this.EquipmentControl_Resize);
			this.ResumeLayout(false);

		}

		#endregion
	}
}

namespace FunkyItemTrackerGUI
{
	partial class CharacterSlot
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
			this.pb_Image = new System.Windows.Forms.PictureBox();
			this.lbl_Name = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
			this.SuspendLayout();
			// 
			// pb_Image
			// 
			this.pb_Image.Location = new System.Drawing.Point(0, 0);
			this.pb_Image.Name = "pb_Image";
			this.pb_Image.Size = new System.Drawing.Size(42, 42);
			this.pb_Image.TabIndex = 0;
			this.pb_Image.TabStop = false;
			this.pb_Image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CharacterSlot_MouseClick);
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Name.Location = new System.Drawing.Point(48, 0);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(60, 24);
			this.lbl_Name.TabIndex = 1;
			this.lbl_Name.Text = "label1";
			this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl_Name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CharacterSlot_MouseClick);
			// 
			// CharacterSlot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbl_Name);
			this.Controls.Add(this.pb_Image);
			this.Name = "CharacterSlot";
			this.Size = new System.Drawing.Size(243, 44);
			this.Leave += new System.EventHandler(this.CharacterSlot_Leave);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CharacterSlot_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pb_Image;
		internal System.Windows.Forms.Label lbl_Name;
	}
}

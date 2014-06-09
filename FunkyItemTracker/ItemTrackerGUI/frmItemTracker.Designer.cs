using System.Windows.Forms;
using FunkyItemTracker.ItemTrackerGUI.Controls;

namespace FunkyItemTracker.ItemTrackerGUI
{
	partial class frmItemTracker
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.flowlayout_Characters = new System.Windows.Forms.FlowLayoutPanel();
			this.panel_Items = new System.Windows.Forms.Panel();
			this.contextMenuCharacter = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showEquippedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showBackpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showStashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.itemViewer = new FunkyItemTracker.ItemTrackerGUI.Controls.ItemPreviewControl();
			this.menuStrip1.SuspendLayout();
			this.contextMenuCharacter.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(942, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "xml";
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// flowlayout_Characters
			// 
			this.flowlayout_Characters.AutoScroll = true;
			this.flowlayout_Characters.BackColor = System.Drawing.Color.White;
			this.flowlayout_Characters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowlayout_Characters.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowlayout_Characters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowlayout_Characters.Location = new System.Drawing.Point(0, 166);
			this.flowlayout_Characters.Name = "flowlayout_Characters";
			this.flowlayout_Characters.Size = new System.Drawing.Size(200, 368);
			this.flowlayout_Characters.TabIndex = 1;
			this.flowlayout_Characters.WrapContents = false;
			// 
			// panel_Items
			// 
			this.panel_Items.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_Items.Location = new System.Drawing.Point(200, 166);
			this.panel_Items.Name = "panel_Items";
			this.panel_Items.Size = new System.Drawing.Size(458, 368);
			this.panel_Items.TabIndex = 2;
			// 
			// contextMenuCharacter
			// 
			this.contextMenuCharacter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEquippedToolStripMenuItem,
            this.showBackpackToolStripMenuItem,
            this.showStashToolStripMenuItem});
			this.contextMenuCharacter.Name = "contextMenuCharacter";
			this.contextMenuCharacter.Size = new System.Drawing.Size(148, 70);
			// 
			// showEquippedToolStripMenuItem
			// 
			this.showEquippedToolStripMenuItem.Name = "showEquippedToolStripMenuItem";
			this.showEquippedToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.showEquippedToolStripMenuItem.Text = "Show Equipped";
			this.showEquippedToolStripMenuItem.Click += new System.EventHandler(this.showEquippedToolStripMenuItem_Click);
			// 
			// showBackpackToolStripMenuItem
			// 
			this.showBackpackToolStripMenuItem.Name = "showBackpackToolStripMenuItem";
			this.showBackpackToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.showBackpackToolStripMenuItem.Text = "Show Backpack";
			// 
			// showStashToolStripMenuItem
			// 
			this.showStashToolStripMenuItem.Name = "showStashToolStripMenuItem";
			this.showStashToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.showStashToolStripMenuItem.Text = "Show Stash";
			this.showStashToolStripMenuItem.Click += new System.EventHandler(this.showStashToolStripMenuItem_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(942, 142);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search";
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(3, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(936, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			this.groupBox2.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(216, 59);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 26);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(198, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(3, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(936, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "^";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// itemViewer
			// 
			this.itemViewer.BackColor = System.Drawing.Color.Black;
			this.itemViewer.Dock = System.Windows.Forms.DockStyle.Right;
			this.itemViewer.Location = new System.Drawing.Point(658, 166);
			this.itemViewer.Name = "itemViewer";
			this.itemViewer.Size = new System.Drawing.Size(284, 368);
			this.itemViewer.TabIndex = 3;
			// 
			// frmItemTracker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 534);
			this.Controls.Add(this.panel_Items);
			this.Controls.Add(this.itemViewer);
			this.Controls.Add(this.flowlayout_Characters);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmItemTracker";
			this.Text = "Item Tracker";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contextMenuCharacter.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FlowLayoutPanel flowlayout_Characters;
		private System.Windows.Forms.ToolStripMenuItem showEquippedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showBackpackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showStashToolStripMenuItem;
		internal System.Windows.Forms.Panel panel_Items;
		internal System.Windows.Forms.ContextMenuStrip contextMenuCharacter;
		internal ItemPreviewControl itemViewer;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button button1;
		private Label label1;
		private Button button2;
		private TextBox textBox1;
		
	}
}


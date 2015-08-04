namespace CrozzleValidator
{
    partial class mainForm
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
            this.msCrozzleMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWordlist = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCrozzle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdLoadFiles = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.msCrozzleMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msCrozzleMenu
            // 
            this.msCrozzleMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msCrozzleMenu.Location = new System.Drawing.Point(0, 0);
            this.msCrozzleMenu.Name = "msCrozzleMenu";
            this.msCrozzleMenu.Size = new System.Drawing.Size(284, 24);
            this.msCrozzleMenu.TabIndex = 1;
            this.msCrozzleMenu.Text = "Crozzle Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWordlist,
            this.tsmCrozzle,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // tsmWordlist
            // 
            this.tsmWordlist.Name = "tsmWordlist";
            this.tsmWordlist.Size = new System.Drawing.Size(152, 22);
            this.tsmWordlist.Text = "Load &Wordlist";
            this.tsmWordlist.Click += new System.EventHandler(this.tsmWordlist_Click);
            // 
            // tsmCrozzle
            // 
            this.tsmCrozzle.Name = "tsmCrozzle";
            this.tsmCrozzle.Size = new System.Drawing.Size(152, 22);
            this.tsmCrozzle.Text = "Load &Crozzle";
            this.tsmCrozzle.Click += new System.EventHandler(this.tsmCrozzle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ofdLoadFiles
            // 
            this.ofdLoadFiles.InitialDirectory = ".";
            this.ofdLoadFiles.SupportMultiDottedExtensions = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 238);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.msCrozzleMenu);
            this.MainMenuStrip = this.msCrozzleMenu;
            this.Name = "mainForm";
            this.Text = "Crozzle Validator";
            this.msCrozzleMenu.ResumeLayout(false);
            this.msCrozzleMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCrozzleMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmWordlist;
        private System.Windows.Forms.ToolStripMenuItem tsmCrozzle;
        private System.Windows.Forms.OpenFileDialog ofdLoadFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}


﻿namespace RestaurantEsemka
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kARYAWANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENURESTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHEFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWORDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSACTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dATAToolStripMenuItem,
            this.cHEFToolStripMenuItem,
            this.tRANSACTIONToolStripMenuItem,
            this.rEPORTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.homeToolStripMenuItem.Text = "HOME";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loginToolStripMenuItem.Image")));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "LOGIN";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "LOGOUT";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXITToolStripMenuItem.Image")));
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // dATAToolStripMenuItem
            // 
            this.dATAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kARYAWANToolStripMenuItem,
            this.mEMBERToolStripMenuItem,
            this.mENURESTOToolStripMenuItem});
            this.dATAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dATAToolStripMenuItem.Image")));
            this.dATAToolStripMenuItem.Name = "dATAToolStripMenuItem";
            this.dATAToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.dATAToolStripMenuItem.Text = "DATA";
            // 
            // kARYAWANToolStripMenuItem
            // 
            this.kARYAWANToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kARYAWANToolStripMenuItem.Image")));
            this.kARYAWANToolStripMenuItem.Name = "kARYAWANToolStripMenuItem";
            this.kARYAWANToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kARYAWANToolStripMenuItem.Text = "KARYAWAN";
            this.kARYAWANToolStripMenuItem.Click += new System.EventHandler(this.kARYAWANToolStripMenuItem_Click);
            // 
            // mEMBERToolStripMenuItem
            // 
            this.mEMBERToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mEMBERToolStripMenuItem.Image")));
            this.mEMBERToolStripMenuItem.Name = "mEMBERToolStripMenuItem";
            this.mEMBERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mEMBERToolStripMenuItem.Text = "MEMBER";
            this.mEMBERToolStripMenuItem.Click += new System.EventHandler(this.mEMBERToolStripMenuItem_Click);
            // 
            // mENURESTOToolStripMenuItem
            // 
            this.mENURESTOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENURESTOToolStripMenuItem.Image")));
            this.mENURESTOToolStripMenuItem.Name = "mENURESTOToolStripMenuItem";
            this.mENURESTOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mENURESTOToolStripMenuItem.Text = "MENU RESTO";
            this.mENURESTOToolStripMenuItem.Click += new System.EventHandler(this.mENURESTOToolStripMenuItem_Click);
            // 
            // cHEFToolStripMenuItem
            // 
            this.cHEFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWORDERToolStripMenuItem});
            this.cHEFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cHEFToolStripMenuItem.Image")));
            this.cHEFToolStripMenuItem.Name = "cHEFToolStripMenuItem";
            this.cHEFToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cHEFToolStripMenuItem.Text = "CHEF";
            // 
            // vIEWORDERToolStripMenuItem
            // 
            this.vIEWORDERToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vIEWORDERToolStripMenuItem.Image")));
            this.vIEWORDERToolStripMenuItem.Name = "vIEWORDERToolStripMenuItem";
            this.vIEWORDERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vIEWORDERToolStripMenuItem.Text = "VIEW ORDER";
            this.vIEWORDERToolStripMenuItem.Click += new System.EventHandler(this.vIEWORDERToolStripMenuItem_Click);
            // 
            // tRANSACTIONToolStripMenuItem
            // 
            this.tRANSACTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oRDERToolStripMenuItem,
            this.pAYMENTToolStripMenuItem});
            this.tRANSACTIONToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tRANSACTIONToolStripMenuItem.Image")));
            this.tRANSACTIONToolStripMenuItem.Name = "tRANSACTIONToolStripMenuItem";
            this.tRANSACTIONToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.tRANSACTIONToolStripMenuItem.Text = "TRANSACTION";
            // 
            // oRDERToolStripMenuItem
            // 
            this.oRDERToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oRDERToolStripMenuItem.Image")));
            this.oRDERToolStripMenuItem.Name = "oRDERToolStripMenuItem";
            this.oRDERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oRDERToolStripMenuItem.Text = "ORDER";
            this.oRDERToolStripMenuItem.Click += new System.EventHandler(this.oRDERToolStripMenuItem_Click);
            // 
            // pAYMENTToolStripMenuItem
            // 
            this.pAYMENTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pAYMENTToolStripMenuItem.Image")));
            this.pAYMENTToolStripMenuItem.Name = "pAYMENTToolStripMenuItem";
            this.pAYMENTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pAYMENTToolStripMenuItem.Text = "PAYMENT";
            this.pAYMENTToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTToolStripMenuItem_Click);
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rEPORTToolStripMenuItem.Image")));
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            this.rEPORTToolStripMenuItem.Click += new System.EventHandler(this.rEPORTToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kARYAWANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENURESTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHEFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWORDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSACTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAYMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
    }
}


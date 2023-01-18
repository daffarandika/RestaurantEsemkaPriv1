namespace RestaurantEsemka
{
    partial class NonTunaiUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBank = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.btnKuitansi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Number";
            // 
            // cbxBank
            // 
            this.cbxBank.FormattingEnabled = true;
            this.cbxBank.Location = new System.Drawing.Point(62, 6);
            this.cbxBank.Name = "cbxBank";
            this.cbxBank.Size = new System.Drawing.Size(218, 21);
            this.cbxBank.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(87, 33);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(193, 20);
            this.tbCardNumber.TabIndex = 5;
            // 
            // btnKuitansi
            // 
            this.btnKuitansi.Location = new System.Drawing.Point(168, 59);
            this.btnKuitansi.Name = "btnKuitansi";
            this.btnKuitansi.Size = new System.Drawing.Size(75, 23);
            this.btnKuitansi.TabIndex = 6;
            this.btnKuitansi.Text = "Kuitansi";
            this.btnKuitansi.UseVisualStyleBackColor = true;
            this.btnKuitansi.Click += new System.EventHandler(this.btnKuitansi_Click);
            // 
            // NonTunaiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKuitansi);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NonTunaiUC";
            this.Size = new System.Drawing.Size(369, 108);
            this.Load += new System.EventHandler(this.NonTunaiUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBank;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Button btnKuitansi;
    }
}

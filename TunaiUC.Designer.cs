namespace RestaurantEsemka
{
    partial class TunaiUC
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
            this.btnKuitansi = new System.Windows.Forms.Button();
            this.tbnSave = new System.Windows.Forms.Button();
            this.tbKembali = new System.Windows.Forms.TextBox();
            this.tbBayar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKuitansi
            // 
            this.btnKuitansi.Location = new System.Drawing.Point(141, 70);
            this.btnKuitansi.Name = "btnKuitansi";
            this.btnKuitansi.Size = new System.Drawing.Size(75, 23);
            this.btnKuitansi.TabIndex = 18;
            this.btnKuitansi.Text = "Kuitansi";
            this.btnKuitansi.UseVisualStyleBackColor = true;
            this.btnKuitansi.Click += new System.EventHandler(this.btnKuitansi_Click);
            // 
            // tbnSave
            // 
            this.tbnSave.Location = new System.Drawing.Point(60, 70);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(75, 23);
            this.tbnSave.TabIndex = 17;
            this.tbnSave.Text = "Save";
            this.tbnSave.UseVisualStyleBackColor = true;
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // tbKembali
            // 
            this.tbKembali.Location = new System.Drawing.Point(60, 28);
            this.tbKembali.Name = "tbKembali";
            this.tbKembali.Size = new System.Drawing.Size(218, 20);
            this.tbKembali.TabIndex = 16;
            // 
            // tbBayar
            // 
            this.tbBayar.Location = new System.Drawing.Point(60, 2);
            this.tbBayar.Name = "tbBayar";
            this.tbBayar.Size = new System.Drawing.Size(218, 20);
            this.tbBayar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kembali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bayar";
            // 
            // TunaiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKuitansi);
            this.Controls.Add(this.tbnSave);
            this.Controls.Add(this.tbKembali);
            this.Controls.Add(this.tbBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TunaiUC";
            this.Size = new System.Drawing.Size(369, 108);
            this.Load += new System.EventHandler(this.TunaiUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKuitansi;
        private System.Windows.Forms.Button tbnSave;
        private System.Windows.Forms.TextBox tbKembali;
        private System.Windows.Forms.TextBox tbBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

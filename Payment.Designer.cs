namespace RestaurantEsemka
{
    partial class Payment
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
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMetode = new System.Windows.Forms.ComboBox();
            this.tbBayar = new System.Windows.Forms.TextBox();
            this.tbKembali = new System.Windows.Forms.TextBox();
            this.tota = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbnSave = new System.Windows.Forms.Button();
            this.cbxOrderID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKuitansi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPayment
            // 
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(29, 51);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(734, 250);
            this.dgvPayment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bayar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kembali";
            // 
            // cbxMetode
            // 
            this.cbxMetode.FormattingEnabled = true;
            this.cbxMetode.Location = new System.Drawing.Point(114, 307);
            this.cbxMetode.Name = "cbxMetode";
            this.cbxMetode.Size = new System.Drawing.Size(218, 21);
            this.cbxMetode.TabIndex = 4;
            this.cbxMetode.Text = "Tunai";
            // 
            // tbBayar
            // 
            this.tbBayar.Location = new System.Drawing.Point(114, 334);
            this.tbBayar.Name = "tbBayar";
            this.tbBayar.Size = new System.Drawing.Size(218, 20);
            this.tbBayar.TabIndex = 5;
            // 
            // tbKembali
            // 
            this.tbKembali.Location = new System.Drawing.Point(114, 360);
            this.tbKembali.Name = "tbKembali";
            this.tbKembali.Size = new System.Drawing.Size(218, 20);
            this.tbKembali.TabIndex = 6;
            // 
            // tota
            // 
            this.tota.AutoSize = true;
            this.tota.Location = new System.Drawing.Point(458, 324);
            this.tota.Name = "tota";
            this.tota.Size = new System.Drawing.Size(37, 13);
            this.tota.TabIndex = 7;
            this.tota.Text = "Total :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(501, 324);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            // 
            // tbnSave
            // 
            this.tbnSave.Location = new System.Drawing.Point(114, 402);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(75, 23);
            this.tbnSave.TabIndex = 9;
            this.tbnSave.Text = "Save";
            this.tbnSave.UseVisualStyleBackColor = true;
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
            // 
            // cbxOrderID
            // 
            this.cbxOrderID.FormattingEnabled = true;
            this.cbxOrderID.Location = new System.Drawing.Point(336, 12);
            this.cbxOrderID.Name = "cbxOrderID";
            this.cbxOrderID.Size = new System.Drawing.Size(159, 21);
            this.cbxOrderID.TabIndex = 10;
            this.cbxOrderID.SelectedIndexChanged += new System.EventHandler(this.cbxOrderID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Order ID";
            // 
            // btnKuitansi
            // 
            this.btnKuitansi.Location = new System.Drawing.Point(195, 402);
            this.btnKuitansi.Name = "btnKuitansi";
            this.btnKuitansi.Size = new System.Drawing.Size(75, 23);
            this.btnKuitansi.TabIndex = 12;
            this.btnKuitansi.Text = "Kuitansi";
            this.btnKuitansi.UseVisualStyleBackColor = true;
            this.btnKuitansi.Click += new System.EventHandler(this.btnKuitansi_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKuitansi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxOrderID);
            this.Controls.Add(this.tbnSave);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tota);
            this.Controls.Add(this.tbKembali);
            this.Controls.Add(this.tbBayar);
            this.Controls.Add(this.cbxMetode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayment);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMetode;
        private System.Windows.Forms.TextBox tbBayar;
        private System.Windows.Forms.TextBox tbKembali;
        private System.Windows.Forms.Label tota;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button tbnSave;
        private System.Windows.Forms.ComboBox cbxOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKuitansi;
    }
}
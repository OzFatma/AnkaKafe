﻿
namespace AnkaKafeUI
{
    partial class SiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMasa = new System.Windows.Forms.Button();
            this.dgvSiparisDetaylar = new System.Windows.Forms.DataGridView();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.cboUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.btnTasi = new System.Windows.Forms.Button();
            this.cboMasaNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutar = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // btnMasa
            // 
            this.btnMasa.Location = new System.Drawing.Point(416, 47);
            this.btnMasa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.Size = new System.Drawing.Size(118, 38);
            this.btnMasa.TabIndex = 1;
            this.btnMasa.Text = "Ekle";
            this.btnMasa.UseVisualStyleBackColor = true;
            // 
            // dgvSiparisDetaylar
            // 
            this.dgvSiparisDetaylar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylar.Location = new System.Drawing.Point(19, 95);
            this.dgvSiparisDetaylar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvSiparisDetaylar.Name = "dgvSiparisDetaylar";
            this.dgvSiparisDetaylar.RowTemplate.Height = 25;
            this.dgvSiparisDetaylar.Size = new System.Drawing.Size(533, 464);
            this.dgvSiparisDetaylar.TabIndex = 2;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(218, 47);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(189, 32);
            this.nudAdet.TabIndex = 3;
            // 
            // cboUrun
            // 
            this.cboUrun.FormattingEnabled = true;
            this.cboUrun.Location = new System.Drawing.Point(19, 47);
            this.cboUrun.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cboUrun.Name = "cboUrun";
            this.cboUrun.Size = new System.Drawing.Size(188, 33);
            this.cboUrun.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa No";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMasaNo.BackColor = System.Drawing.Color.Tomato;
            this.lblMasaNo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.ForeColor = System.Drawing.Color.White;
            this.lblMasaNo.Location = new System.Drawing.Point(562, 95);
            this.lblMasaNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(334, 193);
            this.lblMasaNo.TabIndex = 7;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTasi
            // 
            this.btnTasi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTasi.Location = new System.Drawing.Point(778, 39);
            this.btnTasi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(118, 38);
            this.btnTasi.TabIndex = 8;
            this.btnTasi.Text = "Taşı";
            this.btnTasi.UseVisualStyleBackColor = true;
            // 
            // cboMasaNo
            // 
            this.cboMasaNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMasaNo.FormattingEnabled = true;
            this.cboMasaNo.Location = new System.Drawing.Point(632, 43);
            this.cboMasaNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cboMasaNo.Name = "cboMasaNo";
            this.cboMasaNo.Size = new System.Drawing.Size(136, 33);
            this.cboMasaNo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme tutarı:";
            // 
            // lblOdemeTutar
            // 
            this.lblOdemeTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdemeTutar.AutoSize = true;
            this.lblOdemeTutar.Location = new System.Drawing.Point(769, 305);
            this.lblOdemeTutar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOdemeTutar.Name = "lblOdemeTutar";
            this.lblOdemeTutar.Size = new System.Drawing.Size(61, 25);
            this.lblOdemeTutar.TabIndex = 11;
            this.lblOdemeTutar.Text = "7.55 ₺";
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.DarkRed;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(575, 377);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(5);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(154, 70);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "Sipariş İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            // 
            // btnOde
            // 
            this.btnOde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOde.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOde.ForeColor = System.Drawing.Color.White;
            this.btnOde.Location = new System.Drawing.Point(742, 377);
            this.btnOde.Margin = new System.Windows.Forms.Padding(5);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(154, 70);
            this.btnOde.TabIndex = 13;
            this.btnOde.Text = "Ödeme Al";
            this.btnOde.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnasayfa.BackColor = System.Drawing.Color.MistyRose;
            this.btnAnasayfa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnasayfa.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAnasayfa.Location = new System.Drawing.Point(575, 457);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(321, 97);
            this.btnAnasayfa.TabIndex = 14;
            this.btnAnasayfa.Text = "Anasayfaya Dön";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 666);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblOdemeTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMasaNo);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboUrun);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.dgvSiparisDetaylar);
            this.Controls.Add(this.btnMasa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMasa;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylar;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ComboBox cboUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Button btnTasi;
        private System.Windows.Forms.ComboBox cboMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdemeTutar;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}
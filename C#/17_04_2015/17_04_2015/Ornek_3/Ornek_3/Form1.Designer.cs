﻿namespace Ornek_3
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cbxBirimi = new System.Windows.Forms.ComboBox();
            this.lstAd = new System.Windows.Forms.ListBox();
            this.lstSoyad = new System.Windows.Forms.ListBox();
            this.lstBirimi = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birimi :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(66, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(238, 20);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(68, 38);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(238, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // cbxBirimi
            // 
            this.cbxBirimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBirimi.FormattingEnabled = true;
            this.cbxBirimi.Items.AddRange(new object[] {
            "Bilgi İşlem",
            "Pazarlama",
            "Muhasebe",
            "Hakla İlişkiler"});
            this.cbxBirimi.Location = new System.Drawing.Point(68, 66);
            this.cbxBirimi.Name = "cbxBirimi";
            this.cbxBirimi.Size = new System.Drawing.Size(238, 21);
            this.cbxBirimi.TabIndex = 5;
            // 
            // lstAd
            // 
            this.lstAd.FormattingEnabled = true;
            this.lstAd.Location = new System.Drawing.Point(12, 124);
            this.lstAd.Name = "lstAd";
            this.lstAd.Size = new System.Drawing.Size(120, 329);
            this.lstAd.TabIndex = 6;
            this.lstAd.SelectedIndexChanged += new System.EventHandler(this.Lst_SelectedIndexChanged);
            // 
            // lstSoyad
            // 
            this.lstSoyad.FormattingEnabled = true;
            this.lstSoyad.Location = new System.Drawing.Point(138, 124);
            this.lstSoyad.Name = "lstSoyad";
            this.lstSoyad.Size = new System.Drawing.Size(120, 329);
            this.lstSoyad.TabIndex = 7;
            this.lstSoyad.SelectedIndexChanged += new System.EventHandler(this.Lst_SelectedIndexChanged);
            // 
            // lstBirimi
            // 
            this.lstBirimi.FormattingEnabled = true;
            this.lstBirimi.Location = new System.Drawing.Point(264, 124);
            this.lstBirimi.Name = "lstBirimi";
            this.lstBirimi.Size = new System.Drawing.Size(120, 329);
            this.lstBirimi.TabIndex = 8;
            this.lstBirimi.SelectedIndexChanged += new System.EventHandler(this.Lst_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(336, 15);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(336, 43);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(336, 68);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 489);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstBirimi);
            this.Controls.Add(this.lstSoyad);
            this.Controls.Add(this.lstAd);
            this.Controls.Add(this.cbxBirimi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cbxBirimi;
        private System.Windows.Forms.ListBox lstAd;
        private System.Windows.Forms.ListBox lstSoyad;
        private System.Windows.Forms.ListBox lstBirimi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}


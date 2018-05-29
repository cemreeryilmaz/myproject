namespace Ornek_1
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
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdDiger = new System.Windows.Forms.RadioButton();
            this.rdBeşik = new System.Windows.Forms.RadioButton();
            this.rdGalata = new System.Windows.Forms.RadioButton();
            this.rdFener = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdKadın = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdEvli = new System.Windows.Forms.RadioButton();
            this.rdBekar = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.Location = new System.Drawing.Point(12, 37);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(137, 316);
            this.lstKisiler.TabIndex = 0;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kişiler :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(155, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Detay";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(193, 301);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(106, 301);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(25, 301);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(73, 54);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(195, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(73, 28);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(195, 20);
            this.txtAd.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdDiger);
            this.groupBox4.Controls.Add(this.rdBeşik);
            this.groupBox4.Controls.Add(this.rdGalata);
            this.groupBox4.Controls.Add(this.rdFener);
            this.groupBox4.Location = new System.Drawing.Point(16, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Takımı";
            // 
            // rdDiger
            // 
            this.rdDiger.AutoSize = true;
            this.rdDiger.Checked = true;
            this.rdDiger.Location = new System.Drawing.Point(149, 64);
            this.rdDiger.Name = "rdDiger";
            this.rdDiger.Size = new System.Drawing.Size(50, 17);
            this.rdDiger.TabIndex = 3;
            this.rdDiger.TabStop = true;
            this.rdDiger.Text = "Diğer";
            this.rdDiger.UseVisualStyleBackColor = true;
            // 
            // rdBeşik
            // 
            this.rdBeşik.AutoSize = true;
            this.rdBeşik.Location = new System.Drawing.Point(32, 61);
            this.rdBeşik.Name = "rdBeşik";
            this.rdBeşik.Size = new System.Drawing.Size(65, 17);
            this.rdBeşik.TabIndex = 2;
            this.rdBeşik.Text = "Beşiktaş";
            this.rdBeşik.UseVisualStyleBackColor = true;
            // 
            // rdGalata
            // 
            this.rdGalata.AutoSize = true;
            this.rdGalata.Location = new System.Drawing.Point(144, 26);
            this.rdGalata.Name = "rdGalata";
            this.rdGalata.Size = new System.Drawing.Size(81, 17);
            this.rdGalata.TabIndex = 1;
            this.rdGalata.Text = "Galatasaray";
            this.rdGalata.UseVisualStyleBackColor = true;
            // 
            // rdFener
            // 
            this.rdFener.AutoSize = true;
            this.rdFener.Location = new System.Drawing.Point(28, 24);
            this.rdFener.Name = "rdFener";
            this.rdFener.Size = new System.Drawing.Size(82, 17);
            this.rdFener.TabIndex = 0;
            this.rdFener.Text = "Fenerbahçe";
            this.rdFener.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdKadın);
            this.groupBox3.Controls.Add(this.rdErkek);
            this.groupBox3.Location = new System.Drawing.Point(145, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 82);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cinsiyeti";
            // 
            // rdKadın
            // 
            this.rdKadın.AutoSize = true;
            this.rdKadın.Location = new System.Drawing.Point(31, 46);
            this.rdKadın.Name = "rdKadın";
            this.rdKadın.Size = new System.Drawing.Size(52, 17);
            this.rdKadın.TabIndex = 1;
            this.rdKadın.Text = "Kadın";
            this.rdKadın.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Checked = true;
            this.rdErkek.Location = new System.Drawing.Point(31, 23);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(53, 17);
            this.rdErkek.TabIndex = 0;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdEvli);
            this.groupBox2.Controls.Add(this.rdBekar);
            this.groupBox2.Location = new System.Drawing.Point(16, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medeni Hali";
            // 
            // rdEvli
            // 
            this.rdEvli.AutoSize = true;
            this.rdEvli.Location = new System.Drawing.Point(26, 44);
            this.rdEvli.Name = "rdEvli";
            this.rdEvli.Size = new System.Drawing.Size(42, 17);
            this.rdEvli.TabIndex = 1;
            this.rdEvli.Text = "Evli";
            this.rdEvli.UseVisualStyleBackColor = true;
            // 
            // rdBekar
            // 
            this.rdBekar.AutoSize = true;
            this.rdBekar.Checked = true;
            this.rdBekar.Location = new System.Drawing.Point(26, 23);
            this.rdBekar.Name = "rdBekar";
            this.rdBekar.Size = new System.Drawing.Size(53, 17);
            this.rdBekar.TabIndex = 0;
            this.rdBekar.TabStop = true;
            this.rdBekar.Text = "Bekar";
            this.rdBekar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKisiler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdDiger;
        private System.Windows.Forms.RadioButton rdBeşik;
        private System.Windows.Forms.RadioButton rdGalata;
        private System.Windows.Forms.RadioButton rdFener;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdKadın;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdEvli;
        private System.Windows.Forms.RadioButton rdBekar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


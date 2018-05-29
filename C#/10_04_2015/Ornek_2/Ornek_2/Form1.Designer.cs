namespace Ornek_2
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
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.rdKadın = new System.Windows.Forms.RadioButton();
            this.rdEvli = new System.Windows.Forms.RadioButton();
            this.rdBekar = new System.Windows.Forms.RadioButton();
            this.rdFenerbahce = new System.Windows.Forms.RadioButton();
            this.rdTrabzon = new System.Windows.Forms.RadioButton();
            this.rdDiger = new System.Windows.Forms.RadioButton();
            this.rdGalatasaray = new System.Windows.Forms.RadioButton();
            this.rdBesiktas = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.Location = new System.Drawing.Point(12, 25);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(120, 355);
            this.lstAdSoyad.TabIndex = 0;
            this.lstAdSoyad.SelectedIndexChanged += new System.EventHandler(this.lstAdSoyad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(138, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 362);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(61, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(187, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(61, 63);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdKadın);
            this.groupBox2.Controls.Add(this.rdErkek);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdBekar);
            this.groupBox3.Controls.Add(this.rdEvli);
            this.groupBox3.Location = new System.Drawing.Point(146, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(123, 81);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medeni Hal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdBesiktas);
            this.groupBox4.Controls.Add(this.rdGalatasaray);
            this.groupBox4.Controls.Add(this.rdDiger);
            this.groupBox4.Controls.Add(this.rdTrabzon);
            this.groupBox4.Controls.Add(this.rdFenerbahce);
            this.groupBox4.Location = new System.Drawing.Point(6, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 111);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tuttuğu Takım";
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Checked = true;
            this.rdErkek.Location = new System.Drawing.Point(21, 29);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(53, 17);
            this.rdErkek.TabIndex = 0;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdKadın
            // 
            this.rdKadın.AutoSize = true;
            this.rdKadın.Location = new System.Drawing.Point(21, 52);
            this.rdKadın.Name = "rdKadın";
            this.rdKadın.Size = new System.Drawing.Size(52, 17);
            this.rdKadın.TabIndex = 1;
            this.rdKadın.Text = "Kadın";
            this.rdKadın.UseVisualStyleBackColor = true;
            // 
            // rdEvli
            // 
            this.rdEvli.AutoSize = true;
            this.rdEvli.Location = new System.Drawing.Point(22, 29);
            this.rdEvli.Name = "rdEvli";
            this.rdEvli.Size = new System.Drawing.Size(42, 17);
            this.rdEvli.TabIndex = 0;
            this.rdEvli.Text = "Evli";
            this.rdEvli.UseVisualStyleBackColor = true;
            // 
            // rdBekar
            // 
            this.rdBekar.AutoSize = true;
            this.rdBekar.Checked = true;
            this.rdBekar.Location = new System.Drawing.Point(22, 52);
            this.rdBekar.Name = "rdBekar";
            this.rdBekar.Size = new System.Drawing.Size(53, 17);
            this.rdBekar.TabIndex = 1;
            this.rdBekar.TabStop = true;
            this.rdBekar.Text = "Bekar";
            this.rdBekar.UseVisualStyleBackColor = true;
            // 
            // rdFenerbahce
            // 
            this.rdFenerbahce.AutoSize = true;
            this.rdFenerbahce.Location = new System.Drawing.Point(24, 28);
            this.rdFenerbahce.Name = "rdFenerbahce";
            this.rdFenerbahce.Size = new System.Drawing.Size(82, 17);
            this.rdFenerbahce.TabIndex = 0;
            this.rdFenerbahce.Text = "Fenerbahçe";
            this.rdFenerbahce.UseVisualStyleBackColor = true;
            // 
            // rdTrabzon
            // 
            this.rdTrabzon.AutoSize = true;
            this.rdTrabzon.Location = new System.Drawing.Point(24, 51);
            this.rdTrabzon.Name = "rdTrabzon";
            this.rdTrabzon.Size = new System.Drawing.Size(89, 17);
            this.rdTrabzon.TabIndex = 1;
            this.rdTrabzon.Text = "Trabzon Spor";
            this.rdTrabzon.UseVisualStyleBackColor = true;
            // 
            // rdDiger
            // 
            this.rdDiger.AutoSize = true;
            this.rdDiger.Checked = true;
            this.rdDiger.Location = new System.Drawing.Point(24, 74);
            this.rdDiger.Name = "rdDiger";
            this.rdDiger.Size = new System.Drawing.Size(50, 17);
            this.rdDiger.TabIndex = 2;
            this.rdDiger.TabStop = true;
            this.rdDiger.Text = "Diğer";
            this.rdDiger.UseVisualStyleBackColor = true;
            // 
            // rdGalatasaray
            // 
            this.rdGalatasaray.AutoSize = true;
            this.rdGalatasaray.Location = new System.Drawing.Point(134, 28);
            this.rdGalatasaray.Name = "rdGalatasaray";
            this.rdGalatasaray.Size = new System.Drawing.Size(81, 17);
            this.rdGalatasaray.TabIndex = 3;
            this.rdGalatasaray.Text = "Galatasaray";
            this.rdGalatasaray.UseVisualStyleBackColor = true;
            // 
            // rdBesiktas
            // 
            this.rdBesiktas.AutoSize = true;
            this.rdBesiktas.Location = new System.Drawing.Point(134, 51);
            this.rdBesiktas.Name = "rdBesiktas";
            this.rdBesiktas.Size = new System.Drawing.Size(65, 17);
            this.rdBesiktas.TabIndex = 4;
            this.rdBesiktas.Text = "Beşiktaş";
            this.rdBesiktas.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 329);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(94, 329);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(173, 329);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAdSoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdBesiktas;
        private System.Windows.Forms.RadioButton rdGalatasaray;
        private System.Windows.Forms.RadioButton rdDiger;
        private System.Windows.Forms.RadioButton rdTrabzon;
        private System.Windows.Forms.RadioButton rdFenerbahce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdBekar;
        private System.Windows.Forms.RadioButton rdEvli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdKadın;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


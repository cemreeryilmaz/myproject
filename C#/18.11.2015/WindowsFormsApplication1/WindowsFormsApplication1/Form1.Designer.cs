namespace WindowsFormsApplication1
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
            this.btnGunler = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAylar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnMevsim = new System.Windows.Forms.Button();
            this.lstmevsim = new System.Windows.Forms.ListBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnSırala = new System.Windows.Forms.Button();
            this.lstSırala = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboiller = new System.Windows.Forms.ComboBox();
            this.comboİlçeler = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGunler
            // 
            this.btnGunler.Location = new System.Drawing.Point(24, 35);
            this.btnGunler.Name = "btnGunler";
            this.btnGunler.Size = new System.Drawing.Size(75, 23);
            this.btnGunler.TabIndex = 0;
            this.btnGunler.Text = "Günler";
            this.btnGunler.UseVisualStyleBackColor = true;
            this.btnGunler.Click += new System.EventHandler(this.btnGunler_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(132, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnAylar
            // 
            this.btnAylar.Location = new System.Drawing.Point(24, 64);
            this.btnAylar.Name = "btnAylar";
            this.btnAylar.Size = new System.Drawing.Size(75, 23);
            this.btnAylar.TabIndex = 2;
            this.btnAylar.Text = "Aylar";
            this.btnAylar.UseVisualStyleBackColor = true;
            this.btnAylar.Click += new System.EventHandler(this.btnAylar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(285, 66);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnMevsim
            // 
            this.btnMevsim.Location = new System.Drawing.Point(24, 93);
            this.btnMevsim.Name = "btnMevsim";
            this.btnMevsim.Size = new System.Drawing.Size(75, 23);
            this.btnMevsim.TabIndex = 5;
            this.btnMevsim.Text = "Mevsimler";
            this.btnMevsim.UseVisualStyleBackColor = true;
            this.btnMevsim.Click += new System.EventHandler(this.btnMevsim_Click);
            // 
            // lstmevsim
            // 
            this.lstmevsim.FormattingEnabled = true;
            this.lstmevsim.Location = new System.Drawing.Point(131, 93);
            this.lstmevsim.Name = "lstmevsim";
            this.lstmevsim.Size = new System.Drawing.Size(120, 95);
            this.lstmevsim.TabIndex = 6;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(24, 123);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 7;
            this.btnara.Text = "Dizide Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(24, 153);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(75, 23);
            this.btnSırala.TabIndex = 8;
            this.btnSırala.Text = "Diziyi Sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // lstSırala
            // 
            this.lstSırala.FormattingEnabled = true;
            this.lstSırala.Location = new System.Drawing.Point(131, 194);
            this.lstSırala.Name = "lstSırala";
            this.lstSırala.Size = new System.Drawing.Size(120, 108);
            this.lstSırala.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dizi Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 11;
            this.button2.Text = "Dizinin belirli bölümünü sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "İller : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "İlçeler :";
            // 
            // comboiller
            // 
            this.comboiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboiller.FormattingEnabled = true;
            this.comboiller.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.comboiller.Location = new System.Drawing.Point(333, 153);
            this.comboiller.Name = "comboiller";
            this.comboiller.Size = new System.Drawing.Size(121, 21);
            this.comboiller.TabIndex = 14;
            this.comboiller.SelectedIndexChanged += new System.EventHandler(this.comboiller_SelectedIndexChanged);
            // 
            // comboİlçeler
            // 
            this.comboİlçeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboİlçeler.FormattingEnabled = true;
            this.comboİlçeler.Location = new System.Drawing.Point(333, 191);
            this.comboİlçeler.Name = "comboİlçeler";
            this.comboİlçeler.Size = new System.Drawing.Size(121, 21);
            this.comboİlçeler.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Üret";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(288, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 121);
            this.listBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 421);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboİlçeler);
            this.Controls.Add(this.comboiller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSırala);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.lstmevsim);
            this.Controls.Add(this.btnMevsim);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAylar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnGunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGunler;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAylar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnMevsim;
        private System.Windows.Forms.ListBox lstmevsim;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.ListBox lstSırala;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboiller;
        private System.Windows.Forms.ComboBox comboİlçeler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}


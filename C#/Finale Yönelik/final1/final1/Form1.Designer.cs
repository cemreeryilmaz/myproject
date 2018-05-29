namespace final1
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
            this.components = new System.ComponentModel.Container();
            this.dak = new System.Windows.Forms.Label();
            this.san = new System.Windows.Forms.Label();
            this.Sal = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.PBdakika = new System.Windows.Forms.ProgressBar();
            this.PBsaniye = new System.Windows.Forms.ProgressBar();
            this.PBsalise = new System.Windows.Forms.ProgressBar();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblSalise = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dak
            // 
            this.dak.AutoSize = true;
            this.dak.Location = new System.Drawing.Point(15, 16);
            this.dak.Name = "dak";
            this.dak.Size = new System.Drawing.Size(39, 13);
            this.dak.TabIndex = 0;
            this.dak.Text = "dakika";
            // 
            // san
            // 
            this.san.AutoSize = true;
            this.san.Location = new System.Drawing.Point(15, 43);
            this.san.Name = "san";
            this.san.Size = new System.Drawing.Size(37, 13);
            this.san.TabIndex = 1;
            this.san.Text = "saniye";
            // 
            // Sal
            // 
            this.Sal.AutoSize = true;
            this.Sal.Location = new System.Drawing.Point(14, 71);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(33, 13);
            this.Sal.TabIndex = 2;
            this.Sal.Text = "salise";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(12, 93);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "baslat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(192, 93);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // PBdakika
            // 
            this.PBdakika.Location = new System.Drawing.Point(57, 9);
            this.PBdakika.Maximum = 60;
            this.PBdakika.Name = "PBdakika";
            this.PBdakika.Size = new System.Drawing.Size(210, 23);
            this.PBdakika.TabIndex = 5;
            // 
            // PBsaniye
            // 
            this.PBsaniye.Location = new System.Drawing.Point(57, 35);
            this.PBsaniye.Maximum = 60;
            this.PBsaniye.Name = "PBsaniye";
            this.PBsaniye.Size = new System.Drawing.Size(210, 23);
            this.PBsaniye.TabIndex = 6;
            // 
            // PBsalise
            // 
            this.PBsalise.Location = new System.Drawing.Point(57, 64);
            this.PBsalise.Name = "PBsalise";
            this.PBsalise.Size = new System.Drawing.Size(210, 23);
            this.PBsalise.TabIndex = 7;
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Location = new System.Drawing.Point(274, 16);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(13, 13);
            this.lblDakika.TabIndex = 8;
            this.lblDakika.Text = "0";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Location = new System.Drawing.Point(274, 44);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(13, 13);
            this.lblSaniye.TabIndex = 9;
            this.lblSaniye.Text = "0";
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Location = new System.Drawing.Point(273, 71);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(13, 13);
            this.lblSalise.TabIndex = 10;
            this.lblSalise.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(305, 124);
            this.Controls.Add(this.lblSalise);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.PBsalise);
            this.Controls.Add(this.PBsaniye);
            this.Controls.Add(this.PBdakika);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.san);
            this.Controls.Add(this.dak);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dak;
        private System.Windows.Forms.Label san;
        private System.Windows.Forms.Label Sal;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ProgressBar PBdakika;
        private System.Windows.Forms.ProgressBar PBsaniye;
        private System.Windows.Forms.ProgressBar PBsalise;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Timer timer1;
    }
}


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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prgBarSaat = new System.Windows.Forms.ProgressBar();
            this.prgBarDakika = new System.Windows.Forms.ProgressBar();
            this.prgBarSaniye = new System.Windows.Forms.ProgressBar();
            this.btnArtır = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dakika :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saniye :";
            // 
            // prgBarSaat
            // 
            this.prgBarSaat.Location = new System.Drawing.Point(75, 12);
            this.prgBarSaat.Maximum = 3;
            this.prgBarSaat.Name = "prgBarSaat";
            this.prgBarSaat.Size = new System.Drawing.Size(192, 23);
            this.prgBarSaat.TabIndex = 3;
            // 
            // prgBarDakika
            // 
            this.prgBarDakika.Location = new System.Drawing.Point(75, 41);
            this.prgBarDakika.Maximum = 3;
            this.prgBarDakika.Name = "prgBarDakika";
            this.prgBarDakika.Size = new System.Drawing.Size(192, 23);
            this.prgBarDakika.TabIndex = 4;
            // 
            // prgBarSaniye
            // 
            this.prgBarSaniye.Location = new System.Drawing.Point(75, 70);
            this.prgBarSaniye.Maximum = 3;
            this.prgBarSaniye.Name = "prgBarSaniye";
            this.prgBarSaniye.Size = new System.Drawing.Size(192, 23);
            this.prgBarSaniye.TabIndex = 5;
            // 
            // btnArtır
            // 
            this.btnArtır.Location = new System.Drawing.Point(192, 110);
            this.btnArtır.Name = "btnArtır";
            this.btnArtır.Size = new System.Drawing.Size(75, 23);
            this.btnArtır.TabIndex = 6;
            this.btnArtır.Text = "Artır";
            this.btnArtır.UseVisualStyleBackColor = true;
            this.btnArtır.Click += new System.EventHandler(this.btnArtır_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(75, 110);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(75, 23);
            this.btnAzalt.TabIndex = 7;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Red;
            this.lblSaat.Location = new System.Drawing.Point(273, 10);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(25, 26);
            this.lblSaat.TabIndex = 8;
            this.lblSaat.Text = "0";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.ForeColor = System.Drawing.Color.Red;
            this.lblDakika.Location = new System.Drawing.Point(273, 39);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(25, 26);
            this.lblDakika.TabIndex = 9;
            this.lblDakika.Text = "0";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Red;
            this.lblSaniye.Location = new System.Drawing.Point(273, 68);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(25, 26);
            this.lblSaniye.TabIndex = 10;
            this.lblSaniye.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 145);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArtır);
            this.Controls.Add(this.prgBarSaniye);
            this.Controls.Add(this.prgBarDakika);
            this.Controls.Add(this.prgBarSaat);
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
        private System.Windows.Forms.ProgressBar prgBarSaat;
        private System.Windows.Forms.ProgressBar prgBarDakika;
        private System.Windows.Forms.ProgressBar prgBarSaniye;
        private System.Windows.Forms.Button btnArtır;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
    }
}


namespace Ornek_3
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
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.prgBarSaniye = new System.Windows.Forms.ProgressBar();
            this.prgBarDakika = new System.Windows.Forms.ProgressBar();
            this.prgBarSaat = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasDur = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Red;
            this.lblSaniye.Location = new System.Drawing.Point(259, 68);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(25, 26);
            this.lblSaniye.TabIndex = 21;
            this.lblSaniye.Text = "0";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.ForeColor = System.Drawing.Color.Red;
            this.lblDakika.Location = new System.Drawing.Point(259, 39);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(25, 26);
            this.lblDakika.TabIndex = 20;
            this.lblDakika.Text = "0";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.Red;
            this.lblSaat.Location = new System.Drawing.Point(259, 10);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(25, 26);
            this.lblSaat.TabIndex = 19;
            this.lblSaat.Text = "0";
            // 
            // prgBarSaniye
            // 
            this.prgBarSaniye.Location = new System.Drawing.Point(61, 70);
            this.prgBarSaniye.Maximum = 3;
            this.prgBarSaniye.Name = "prgBarSaniye";
            this.prgBarSaniye.Size = new System.Drawing.Size(192, 23);
            this.prgBarSaniye.TabIndex = 16;
            // 
            // prgBarDakika
            // 
            this.prgBarDakika.Location = new System.Drawing.Point(61, 41);
            this.prgBarDakika.Maximum = 3;
            this.prgBarDakika.Name = "prgBarDakika";
            this.prgBarDakika.Size = new System.Drawing.Size(192, 23);
            this.prgBarDakika.TabIndex = 15;
            // 
            // prgBarSaat
            // 
            this.prgBarSaat.Location = new System.Drawing.Point(61, 12);
            this.prgBarSaat.Maximum = 3;
            this.prgBarSaat.Name = "prgBarSaat";
            this.prgBarSaat.Size = new System.Drawing.Size(192, 23);
            this.prgBarSaat.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Saniye :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dakika :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Saat :";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasDur
            // 
            this.btnBasDur.Location = new System.Drawing.Point(178, 99);
            this.btnBasDur.Name = "btnBasDur";
            this.btnBasDur.Size = new System.Drawing.Size(75, 23);
            this.btnBasDur.TabIndex = 22;
            this.btnBasDur.Text = "Başlat";
            this.btnBasDur.UseVisualStyleBackColor = true;
            this.btnBasDur.Click += new System.EventHandler(this.btnBasDur_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Location = new System.Drawing.Point(97, 99);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(75, 23);
            this.btnSıfırla.TabIndex = 23;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = true;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 142);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnBasDur);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.lblSaat);
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

        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.ProgressBar prgBarSaniye;
        private System.Windows.Forms.ProgressBar prgBarDakika;
        private System.Windows.Forms.ProgressBar prgBarSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBasDur;
        private System.Windows.Forms.Button btnSıfırla;
    }
}


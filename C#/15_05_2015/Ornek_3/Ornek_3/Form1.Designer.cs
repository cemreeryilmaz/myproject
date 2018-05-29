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
            this.prgDakika = new System.Windows.Forms.ProgressBar();
            this.prgSaniye = new System.Windows.Forms.ProgressBar();
            this.prgSalise = new System.Windows.Forms.ProgressBar();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.lblSalise = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prgDakika
            // 
            this.prgDakika.Location = new System.Drawing.Point(12, 21);
            this.prgDakika.Name = "prgDakika";
            this.prgDakika.Size = new System.Drawing.Size(231, 23);
            this.prgDakika.TabIndex = 0;
            // 
            // prgSaniye
            // 
            this.prgSaniye.Location = new System.Drawing.Point(13, 50);
            this.prgSaniye.Maximum = 59;
            this.prgSaniye.Name = "prgSaniye";
            this.prgSaniye.Size = new System.Drawing.Size(231, 23);
            this.prgSaniye.TabIndex = 1;
            // 
            // prgSalise
            // 
            this.prgSalise.Location = new System.Drawing.Point(13, 79);
            this.prgSalise.Maximum = 99;
            this.prgSalise.Name = "prgSalise";
            this.prgSalise.Size = new System.Drawing.Size(231, 23);
            this.prgSalise.TabIndex = 2;
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(249, 21);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(25, 26);
            this.lblDakika.TabIndex = 3;
            this.lblDakika.Text = "0";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(250, 50);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(25, 26);
            this.lblSaniye.TabIndex = 4;
            this.lblSaniye.Text = "0";
            // 
            // lblSalise
            // 
            this.lblSalise.AutoSize = true;
            this.lblSalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalise.Location = new System.Drawing.Point(250, 79);
            this.lblSalise.Name = "lblSalise";
            this.lblSalise.Size = new System.Drawing.Size(25, 26);
            this.lblSalise.TabIndex = 5;
            this.lblSalise.Text = "0";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(137, 124);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 6;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Location = new System.Drawing.Point(56, 124);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(75, 23);
            this.btnSıfırla.TabIndex = 7;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = true;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 159);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblSalise);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.prgSalise);
            this.Controls.Add(this.prgSaniye);
            this.Controls.Add(this.prgDakika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgDakika;
        private System.Windows.Forms.ProgressBar prgSaniye;
        private System.Windows.Forms.ProgressBar prgSalise;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label lblSalise;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Timer timer1;
    }
}


﻿namespace Ornek_4
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
            this.lblKrono = new System.Windows.Forms.Label();
            this.btnBasDur = new System.Windows.Forms.Button();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblKrono
            // 
            this.lblKrono.AutoSize = true;
            this.lblKrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKrono.ForeColor = System.Drawing.Color.Maroon;
            this.lblKrono.Location = new System.Drawing.Point(53, 39);
            this.lblKrono.Name = "lblKrono";
            this.lblKrono.Size = new System.Drawing.Size(169, 31);
            this.lblKrono.TabIndex = 0;
            this.lblKrono.Text = "00:00:00:00";
            // 
            // btnBasDur
            // 
            this.btnBasDur.Location = new System.Drawing.Point(147, 108);
            this.btnBasDur.Name = "btnBasDur";
            this.btnBasDur.Size = new System.Drawing.Size(75, 23);
            this.btnBasDur.TabIndex = 1;
            this.btnBasDur.Text = "Başlat";
            this.btnBasDur.UseVisualStyleBackColor = true;
            this.btnBasDur.Click += new System.EventHandler(this.btnBasDur_Click);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.Location = new System.Drawing.Point(59, 108);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(75, 23);
            this.btnSıfırla.TabIndex = 2;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = true;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.btnSıfırla);
            this.Controls.Add(this.btnBasDur);
            this.Controls.Add(this.lblKrono);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKrono;
        private System.Windows.Forms.Button btnBasDur;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.Timer timer1;
    }
}

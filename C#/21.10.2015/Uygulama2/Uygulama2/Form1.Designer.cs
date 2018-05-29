namespace Uygulama2
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnsatirsayisi = new System.Windows.Forms.Button();
            this.btnseciliolanicikart = new System.Windows.Forms.Button();
            this.lstSatir = new System.Windows.Forms.ListBox();
            this.lblsatirsayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(184, 25);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(128, 20);
            this.txtMetin.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(337, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(188, 60);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(224, 29);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Seçili Olanı Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnsatirsayisi
            // 
            this.btnsatirsayisi.Location = new System.Drawing.Point(188, 109);
            this.btnsatirsayisi.Name = "btnsatirsayisi";
            this.btnsatirsayisi.Size = new System.Drawing.Size(224, 29);
            this.btnsatirsayisi.TabIndex = 3;
            this.btnsatirsayisi.Text = "Satır Sayısı";
            this.btnsatirsayisi.UseVisualStyleBackColor = true;
            this.btnsatirsayisi.Click += new System.EventHandler(this.btnsatirsayisi_Click);
            // 
            // btnseciliolanicikart
            // 
            this.btnseciliolanicikart.Location = new System.Drawing.Point(188, 156);
            this.btnseciliolanicikart.Name = "btnseciliolanicikart";
            this.btnseciliolanicikart.Size = new System.Drawing.Size(224, 29);
            this.btnseciliolanicikart.TabIndex = 4;
            this.btnseciliolanicikart.Text = "Seçili Olanı Çıkart";
            this.btnseciliolanicikart.UseVisualStyleBackColor = true;
            this.btnseciliolanicikart.Click += new System.EventHandler(this.btnseciliolanicikart_Click);
            // 
            // lstSatir
            // 
            this.lstSatir.FormattingEnabled = true;
            this.lstSatir.Location = new System.Drawing.Point(12, 25);
            this.lstSatir.Name = "lstSatir";
            this.lstSatir.Size = new System.Drawing.Size(129, 199);
            this.lstSatir.TabIndex = 5;
            // 
            // lblsatirsayisi
            // 
            this.lblsatirsayisi.AutoSize = true;
            this.lblsatirsayisi.Location = new System.Drawing.Point(19, 242);
            this.lblsatirsayisi.Name = "lblsatirsayisi";
            this.lblsatirsayisi.Size = new System.Drawing.Size(35, 13);
            this.lblsatirsayisi.TabIndex = 6;
            this.lblsatirsayisi.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 351);
            this.Controls.Add(this.lblsatirsayisi);
            this.Controls.Add(this.lstSatir);
            this.Controls.Add(this.btnseciliolanicikart);
            this.Controls.Add(this.btnsatirsayisi);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnsatirsayisi;
        private System.Windows.Forms.Button btnseciliolanicikart;
        private System.Windows.Forms.ListBox lstSatir;
        private System.Windows.Forms.Label lblsatirsayisi;
    }
}


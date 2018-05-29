namespace Nesneye_Odaklanma_Gizleme_Ve_Gösterme
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnİsimOdakla = new System.Windows.Forms.Button();
            this.btnSoyadOdakla = new System.Windows.Forms.Button();
            this.btnArmut = new System.Windows.Forms.Button();
            this.btnElma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(212, 53);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(71, 53);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnİsimOdakla
            // 
            this.btnİsimOdakla.Location = new System.Drawing.Point(19, 141);
            this.btnİsimOdakla.Name = "btnİsimOdakla";
            this.btnİsimOdakla.Size = new System.Drawing.Size(69, 75);
            this.btnİsimOdakla.TabIndex = 5;
            this.btnİsimOdakla.Text = "İsme Odakla";
            this.btnİsimOdakla.UseVisualStyleBackColor = true;
            this.btnİsimOdakla.Click += new System.EventHandler(this.btnİsimOdakla_Click);
            // 
            // btnSoyadOdakla
            // 
            this.btnSoyadOdakla.Location = new System.Drawing.Point(113, 141);
            this.btnSoyadOdakla.Name = "btnSoyadOdakla";
            this.btnSoyadOdakla.Size = new System.Drawing.Size(71, 75);
            this.btnSoyadOdakla.TabIndex = 6;
            this.btnSoyadOdakla.Text = "Soyada odakla";
            this.btnSoyadOdakla.UseVisualStyleBackColor = true;
            this.btnSoyadOdakla.Click += new System.EventHandler(this.btnSoyadOdakla_Click);
            // 
            // btnArmut
            // 
            this.btnArmut.Location = new System.Drawing.Point(331, 139);
            this.btnArmut.Name = "btnArmut";
            this.btnArmut.Size = new System.Drawing.Size(89, 55);
            this.btnArmut.TabIndex = 7;
            this.btnArmut.Text = "Armut Aktif Elma Pasif";
            this.btnArmut.UseVisualStyleBackColor = true;
            this.btnArmut.Click += new System.EventHandler(this.btnArmutAktif_Click);
            // 
            // btnElma
            // 
            this.btnElma.Location = new System.Drawing.Point(331, 200);
            this.btnElma.Name = "btnElma";
            this.btnElma.Size = new System.Drawing.Size(89, 46);
            this.btnElma.TabIndex = 8;
            this.btnElma.Text = "Elma Aktif Armut Pasif";
            this.btnElma.UseVisualStyleBackColor = true;
            this.btnElma.Click += new System.EventHandler(this.btnElmaAktif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 340);
            this.Controls.Add(this.btnElma);
            this.Controls.Add(this.btnArmut);
            this.Controls.Add(this.btnSoyadOdakla);
            this.Controls.Add(this.btnİsimOdakla);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnİsimOdakla;
        private System.Windows.Forms.Button btnSoyadOdakla;
        private System.Windows.Forms.Button btnArmut;
        private System.Windows.Forms.Button btnElma;
    }
}


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
            this.cbxSehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.btnEkle_1 = new System.Windows.Forms.Button();
            this.btnEkle_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSehir
            // 
            this.cbxSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSehir.FormattingEnabled = true;
            this.cbxSehir.Location = new System.Drawing.Point(73, 51);
            this.cbxSehir.Name = "cbxSehir";
            this.cbxSehir.Size = new System.Drawing.Size(192, 21);
            this.cbxSehir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehir Seç :";
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.Location = new System.Drawing.Point(73, 78);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.Size = new System.Drawing.Size(192, 173);
            this.lstSehirler.TabIndex = 3;
            // 
            // txtSehir
            // 
            this.txtSehir.Location = new System.Drawing.Point(73, 25);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(192, 20);
            this.txtSehir.TabIndex = 4;
            // 
            // btnEkle_1
            // 
            this.btnEkle_1.Location = new System.Drawing.Point(271, 25);
            this.btnEkle_1.Name = "btnEkle_1";
            this.btnEkle_1.Size = new System.Drawing.Size(75, 20);
            this.btnEkle_1.TabIndex = 5;
            this.btnEkle_1.Text = "Ekle";
            this.btnEkle_1.UseVisualStyleBackColor = true;
            this.btnEkle_1.Click += new System.EventHandler(this.btnEkle_1_Click);
            // 
            // btnEkle_2
            // 
            this.btnEkle_2.Location = new System.Drawing.Point(271, 51);
            this.btnEkle_2.Name = "btnEkle_2";
            this.btnEkle_2.Size = new System.Drawing.Size(75, 20);
            this.btnEkle_2.TabIndex = 6;
            this.btnEkle_2.Text = "Ekle";
            this.btnEkle_2.UseVisualStyleBackColor = true;
            this.btnEkle_2.Click += new System.EventHandler(this.btnEkle_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(379, 277);
            this.Controls.Add(this.btnEkle_2);
            this.Controls.Add(this.btnEkle_1);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSehir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSehirler;
        private System.Windows.Forms.TextBox txtSehir;
        private System.Windows.Forms.Button btnEkle_1;
        private System.Windows.Forms.Button btnEkle_2;
    }
}


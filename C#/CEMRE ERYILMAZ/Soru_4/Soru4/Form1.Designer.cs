namespace Soru4
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
            this.btnkarsilastir = new System.Windows.Forms.Button();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnkarsilastir
            // 
            this.btnkarsilastir.Location = new System.Drawing.Point(21, 92);
            this.btnkarsilastir.Name = "btnkarsilastir";
            this.btnkarsilastir.Size = new System.Drawing.Size(215, 55);
            this.btnkarsilastir.TabIndex = 0;
            this.btnkarsilastir.Text = "0\'dan Küçük Veya 100\'den Büyük Mü?";
            this.btnkarsilastir.UseVisualStyleBackColor = true;
            this.btnkarsilastir.Click += new System.EventHandler(this.btnkarsilastir_Click);
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(49, 49);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(146, 20);
            this.txtsayi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.btnkarsilastir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkarsilastir;
        private System.Windows.Forms.TextBox txtsayi;
    }
}


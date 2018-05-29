namespace Ornek_6
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
            this.lblSayac = new System.Windows.Forms.Label();
            this.btnArtır = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.ForeColor = System.Drawing.Color.Maroon;
            this.lblSayac.Location = new System.Drawing.Point(0, 0);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(284, 56);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "label1";
            this.lblSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArtır
            // 
            this.btnArtır.Location = new System.Drawing.Point(169, 59);
            this.btnArtır.Name = "btnArtır";
            this.btnArtır.Size = new System.Drawing.Size(75, 23);
            this.btnArtır.TabIndex = 1;
            this.btnArtır.Text = "Artır";
            this.btnArtır.UseVisualStyleBackColor = true;
            this.btnArtır.Click += new System.EventHandler(this.btnArtır_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(42, 59);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(75, 23);
            this.btnAzalt.TabIndex = 2;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArtır);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Button btnArtır;
        private System.Windows.Forms.Button btnAzalt;
    }
}


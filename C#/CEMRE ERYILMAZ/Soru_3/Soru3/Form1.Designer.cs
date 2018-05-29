namespace Soru3
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
            this.txtx = new System.Windows.Forms.TextBox();
            this.btnarasinda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(29, 34);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(162, 20);
            this.txtx.TabIndex = 0;
            // 
            // btnarasinda
            // 
            this.btnarasinda.Location = new System.Drawing.Point(29, 72);
            this.btnarasinda.Name = "btnarasinda";
            this.btnarasinda.Size = new System.Drawing.Size(162, 36);
            this.btnarasinda.TabIndex = 1;
            this.btnarasinda.Text = "0-100 Arasında Mı?";
            this.btnarasinda.UseVisualStyleBackColor = true;
            this.btnarasinda.Click += new System.EventHandler(this.btnarasinda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnarasinda);
            this.Controls.Add(this.txtx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Button btnarasinda;
    }
}


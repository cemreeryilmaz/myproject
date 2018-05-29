namespace Soru_1
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
            this.txtbk = new System.Windows.Forms.TextBox();
            this.btnbk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbk
            // 
            this.txtbk.Location = new System.Drawing.Point(44, 35);
            this.txtbk.Name = "txtbk";
            this.txtbk.Size = new System.Drawing.Size(156, 20);
            this.txtbk.TabIndex = 0;
            // 
            // btnbk
            // 
            this.btnbk.Location = new System.Drawing.Point(44, 92);
            this.btnbk.Name = "btnbk";
            this.btnbk.Size = new System.Drawing.Size(156, 39);
            this.btnbk.TabIndex = 1;
            this.btnbk.Text = "10\'dan Büyük Mü Küçük Mü?";
            this.btnbk.UseVisualStyleBackColor = true;
            this.btnbk.Click += new System.EventHandler(this.btnbk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnbk);
            this.Controls.Add(this.txtbk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbk;
        private System.Windows.Forms.Button btnbk;
    }
}


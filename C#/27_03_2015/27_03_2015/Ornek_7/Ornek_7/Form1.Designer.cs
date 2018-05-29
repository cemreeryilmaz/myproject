namespace Ornek_7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnYukarı = new System.Windows.Forms.Button();
            this.btnAsagı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Eleman 1",
            "Eleman 2",
            "Eleman 3",
            "Eleman 4",
            "Eleman 5",
            "Eleman 6",
            "Eleman 7",
            "Eleman 8",
            "Eleman 9",
            "Eleman 10"});
            this.listBox1.Location = new System.Drawing.Point(45, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 0;
            // 
            // btnYukarı
            // 
            this.btnYukarı.Location = new System.Drawing.Point(171, 30);
            this.btnYukarı.Name = "btnYukarı";
            this.btnYukarı.Size = new System.Drawing.Size(47, 23);
            this.btnYukarı.TabIndex = 1;
            this.btnYukarı.Text = "Yukarı";
            this.btnYukarı.UseVisualStyleBackColor = true;
            this.btnYukarı.Click += new System.EventHandler(this.btnYukarı_Click);
            // 
            // btnAsagı
            // 
            this.btnAsagı.Location = new System.Drawing.Point(171, 154);
            this.btnAsagı.Name = "btnAsagı";
            this.btnAsagı.Size = new System.Drawing.Size(47, 23);
            this.btnAsagı.TabIndex = 2;
            this.btnAsagı.Text = "Aşağı";
            this.btnAsagı.UseVisualStyleBackColor = true;
            this.btnAsagı.Click += new System.EventHandler(this.btnAsagı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 224);
            this.Controls.Add(this.btnAsagı);
            this.Controls.Add(this.btnYukarı);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnYukarı;
        private System.Windows.Forms.Button btnAsagı;
    }
}


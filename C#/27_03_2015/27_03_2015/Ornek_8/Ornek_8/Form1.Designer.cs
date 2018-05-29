namespace Ornek_8
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSaga = new System.Windows.Forms.Button();
            this.btnSola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Eleman 1",
            "Eleman 10",
            "Eleman 2",
            "Eleman 3",
            "Eleman 4",
            "Eleman 5",
            "Eleman 6",
            "Eleman 7",
            "Eleman 8",
            "Eleman 9"});
            this.listBox1.Location = new System.Drawing.Point(22, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(229, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 147);
            this.listBox2.TabIndex = 2;
            // 
            // btnSaga
            // 
            this.btnSaga.Location = new System.Drawing.Point(148, 82);
            this.btnSaga.Name = "btnSaga";
            this.btnSaga.Size = new System.Drawing.Size(75, 23);
            this.btnSaga.TabIndex = 3;
            this.btnSaga.Text = ">>";
            this.btnSaga.UseVisualStyleBackColor = true;
            this.btnSaga.Click += new System.EventHandler(this.btnSaga_Click);
            // 
            // btnSola
            // 
            this.btnSola.Location = new System.Drawing.Point(148, 111);
            this.btnSola.Name = "btnSola";
            this.btnSola.Size = new System.Drawing.Size(75, 23);
            this.btnSola.TabIndex = 4;
            this.btnSola.Text = "<<";
            this.btnSola.UseVisualStyleBackColor = true;
            this.btnSola.Click += new System.EventHandler(this.btnSola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 223);
            this.Controls.Add(this.btnSola);
            this.Controls.Add(this.btnSaga);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSaga;
        private System.Windows.Forms.Button btnSola;
    }
}


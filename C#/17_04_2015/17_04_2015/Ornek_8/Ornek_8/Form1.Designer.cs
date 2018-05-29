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
            this.nmud_red = new System.Windows.Forms.NumericUpDown();
            this.nmud_green = new System.Windows.Forms.NumericUpDown();
            this.nmud_blue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // nmud_red
            // 
            this.nmud_red.Location = new System.Drawing.Point(15, 26);
            this.nmud_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmud_red.Name = "nmud_red";
            this.nmud_red.Size = new System.Drawing.Size(76, 20);
            this.nmud_red.TabIndex = 0;
            this.nmud_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmud_red.ThousandsSeparator = true;
            this.nmud_red.ValueChanged += new System.EventHandler(this.NMUD_ValueChanged);
            // 
            // nmud_green
            // 
            this.nmud_green.Location = new System.Drawing.Point(97, 26);
            this.nmud_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmud_green.Name = "nmud_green";
            this.nmud_green.Size = new System.Drawing.Size(76, 20);
            this.nmud_green.TabIndex = 1;
            this.nmud_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmud_green.ThousandsSeparator = true;
            this.nmud_green.ValueChanged += new System.EventHandler(this.NMUD_ValueChanged);
            // 
            // nmud_blue
            // 
            this.nmud_blue.Location = new System.Drawing.Point(179, 26);
            this.nmud_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmud_blue.Name = "nmud_blue";
            this.nmud_blue.Size = new System.Drawing.Size(76, 20);
            this.nmud_blue.TabIndex = 2;
            this.nmud_blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmud_blue.ThousandsSeparator = true;
            this.nmud_blue.ValueChanged += new System.EventHandler(this.NMUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kırmızı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yeşil :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mavi :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(15, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 118);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 188);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmud_blue);
            this.Controls.Add(this.nmud_green);
            this.Controls.Add(this.nmud_red);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmud_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmud_red;
        private System.Windows.Forms.NumericUpDown nmud_green;
        private System.Windows.Forms.NumericUpDown nmud_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}


namespace Ornek_5
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
            this.dtpDTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğum Tarihi :";
            // 
            // dtpDTarih
            // 
            this.dtpDTarih.Location = new System.Drawing.Point(101, 28);
            this.dtpDTarih.Name = "dtpDTarih";
            this.dtpDTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpDTarih.TabIndex = 1;
            this.dtpDTarih.ValueChanged += new System.EventHandler(this.dtpDTarih_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yaş :";
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(101, 54);
            this.txtYas.Name = "txtYas";
            this.txtYas.ReadOnly = true;
            this.txtYas.Size = new System.Drawing.Size(200, 20);
            this.txtYas.TabIndex = 3;
            this.txtYas.Text = "0";
            this.txtYas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 123);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDTarih);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYas;
    }
}


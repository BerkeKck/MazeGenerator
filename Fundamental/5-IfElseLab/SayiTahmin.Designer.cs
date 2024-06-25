namespace _5_IfElseLab
{
    partial class SayiTahmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tahmin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(26, 109);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(21, 20);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "...";
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Location = new System.Drawing.Point(26, 9);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(162, 20);
            this.lblTahmin.TabIndex = 3;
            this.lblTahmin.Text = "Kalan Tahmin Hakki 5";
            // 
            // SayiTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "SayiTahmin";
            this.Text = "SayiTahmin";
            this.Load += new System.EventHandler(this.SayiTahmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblTahmin;
    }
}
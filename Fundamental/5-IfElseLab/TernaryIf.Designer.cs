namespace _5_IfElseLab
{
    partial class TernaryIf
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblRastgeleKarakterler = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblHak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(375, 114);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(101, 40);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(39, 24);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(903, 33);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "Lütfen aşagidaki görmüş oldugunuz karakterleri TextBox icerisine yaziniz";
            // 
            // lblRastgeleKarakterler
            // 
            this.lblRastgeleKarakterler.AutoSize = true;
            this.lblRastgeleKarakterler.Location = new System.Drawing.Point(57, 78);
            this.lblRastgeleKarakterler.Name = "lblRastgeleKarakterler";
            this.lblRastgeleKarakterler.Size = new System.Drawing.Size(38, 33);
            this.lblRastgeleKarakterler.TabIndex = 3;
            this.lblRastgeleKarakterler.Text = "...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 29);
            this.textBox1.TabIndex = 4;
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(57, 155);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(216, 33);
            this.lblHak.TabIndex = 5;
            this.lblHak.Text = "Kalan Hakkiniz 5";
            // 
            // TernaryIf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 134);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRastgeleKarakterler);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnGiris);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "TernaryIf";
            this.Text = "TernaryIf";
            this.Load += new System.EventHandler(this.TernaryIf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblRastgeleKarakterler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHak;
    }
}
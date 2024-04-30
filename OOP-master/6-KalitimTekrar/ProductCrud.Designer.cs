namespace _6_KalitimTekrar
{
    partial class ProductCrud
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
            kategoriCmb = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)northwindDs).BeginInit();
            SuspendLayout();
            // 
            // kategoriCmb
            // 
            kategoriCmb.FormattingEnabled = true;
            kategoriCmb.Location = new Point(221, 164);
            kategoriCmb.Name = "kategoriCmb";
            kategoriCmb.Size = new Size(218, 33);
            kategoriCmb.TabIndex = 0;
            kategoriCmb.SelectedIndexChanged += kategoriCmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 169);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // ProductCrud
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 812);
            Controls.Add(label1);
            Controls.Add(kategoriCmb);
            Name = "ProductCrud";
            Text = "ProductCrud";
            Load += ProductCrud_Load;
            ((System.ComponentModel.ISupportInitialize)northwindDs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox kategoriCmb;
        private Label label1;
    }
}
namespace _8_ForDongusu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(39, 66);
            button1.Name = "button1";
            button1.Size = new Size(145, 52);
            button1.TabIndex = 0;
            button1.Text = "1-100";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(400, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(450, 904);
            listBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(39, 143);
            button2.Name = "button2";
            button2.Size = new Size(145, 52);
            button2.TabIndex = 2;
            button2.Text = "100-1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(39, 232);
            button3.Name = "button3";
            button3.Size = new Size(188, 52);
            button3.TabIndex = 3;
            button3.Text = "1-100 cift sayilar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(39, 310);
            button4.Name = "button4";
            button4.Size = new Size(188, 52);
            button4.TabIndex = 4;
            button4.Text = "a-z Harfler";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(39, 390);
            button5.Name = "button5";
            button5.Size = new Size(188, 52);
            button5.TabIndex = 5;
            button5.Text = "2000 Sonrasi yillar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(44, 463);
            button6.Name = "button6";
            button6.Size = new Size(183, 34);
            button6.TabIndex = 6;
            button6.Text = "Tam Bolunenler Listesi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // button7
            // 
            button7.Location = new Point(44, 521);
            button7.Name = "button7";
            button7.Size = new Size(183, 34);
            button7.TabIndex = 8;
            button7.Text = "Faktoryel";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(44, 576);
            button8.Name = "button8";
            button8.Size = new Size(183, 34);
            button8.TabIndex = 9;
            button8.Text = "Carpim Tablosu";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(44, 643);
            button9.Name = "button9";
            button9.Size = new Size(183, 34);
            button9.TabIndex = 10;
            button9.Text = "Farkli Carpma işlemi";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 1019);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}

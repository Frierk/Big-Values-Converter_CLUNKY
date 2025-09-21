namespace Big_Values_Converter
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 87);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 4;
            label1.Text = "^";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 181);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 5;
            label2.Text = "^";
            // 
            // button1
            // 
            button1.Location = new Point(508, 85);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Binary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(377, 85);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Normal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 46);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 8;
            label3.Text = "From:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "20", "30", "40" });
            comboBox1.Location = new Point(212, 85);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(77, 33);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "20", "30", "40" });
            comboBox2.Location = new Point(377, 176);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(77, 33);
            comboBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 138);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 13;
            label6.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 47);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 16;
            label4.Text = "Mode = Normal";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 265);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 31);
            textBox2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 224);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 18;
            label5.Text = "Total:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 31);
            textBox3.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 328);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Converter (Powers)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
    }
}

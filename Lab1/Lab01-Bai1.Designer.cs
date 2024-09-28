namespace Lab1
{
    partial class Lab01_Bai1
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
            button3 = new Button();
            button2 = new Button();
            Tim = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            s3 = new Label();
            s2 = new Label();
            s1 = new Label();
            label1 = new Label();
            label2 = new Label();
            min = new TextBox();
            max = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.AccessibleDescription = "exit";
            button3.Location = new Point(552, 142);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AccessibleDescription = "Xoa";
            button2.Location = new Point(299, 142);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tim
            // 
            Tim.Location = new Point(65, 142);
            Tim.Name = "Tim";
            Tim.Size = new Size(94, 29);
            Tim.TabIndex = 15;
            Tim.Text = "Tìm";
            Tim.UseVisualStyleBackColor = true;
            Tim.Click += Tim_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(652, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(399, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // s3
            // 
            s3.AutoSize = true;
            s3.Font = new Font("Segoe UI", 16F);
            s3.Location = new Point(530, 38);
            s3.Name = "s3";
            s3.Size = new Size(116, 37);
            s3.TabIndex = 11;
            s3.Text = "Số thứ 3";
            // 
            // s2
            // 
            s2.AutoSize = true;
            s2.Font = new Font("Segoe UI", 16F);
            s2.Location = new Point(277, 38);
            s2.Name = "s2";
            s2.Size = new Size(116, 37);
            s2.TabIndex = 10;
            s2.Text = "Số thứ 2";
            // 
            // s1
            // 
            s1.AutoSize = true;
            s1.Font = new Font("Segoe UI", 16F);
            s1.Location = new Point(24, 37);
            s1.Name = "s1";
            s1.Size = new Size(116, 37);
            s1.TabIndex = 9;
            s1.Text = "Số thứ 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 247);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 18;
            label1.Text = "Số Lớn Nhất ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 247);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 19;
            label2.Text = "Số Nhỏ Nhất ";
            // 
            // min
            // 
            min.Location = new Point(475, 240);
            min.Name = "min";
            min.ReadOnly = true;
            min.Size = new Size(125, 27);
            min.TabIndex = 20;
            // 
            // max
            // 
            max.Location = new Point(146, 240);
            max.Name = "max";
            max.ReadOnly = true;
            max.Size = new Size(125, 27);
            max.TabIndex = 21;
            // 
            // Lab01_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 308);
            Controls.Add(max);
            Controls.Add(min);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Tim);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(s3);
            Controls.Add(s2);
            Controls.Add(s1);
            Name = "Lab01_Bai1";
            Text = "Lab01_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button button3;
        private Button button2;
        private Button Tim;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label s3;
        private Label s2;
        private Label s1;
        private Label label1;
        private Label label2;
        private TextBox min;
        private TextBox max;
    }
}
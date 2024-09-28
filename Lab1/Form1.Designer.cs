namespace Lab1
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
            bai_1 = new Button();
            bai_2 = new Button();
            bai_3 = new Button();
            bai_4 = new Button();
            bai_5 = new Button();
            SuspendLayout();
            // 
            // bai_1
            // 
            bai_1.Location = new Point(22, 74);
            bai_1.Name = "bai_1";
            bai_1.Size = new Size(168, 38);
            bai_1.TabIndex = 0;
            bai_1.Text = "Bài 1";
            bai_1.UseVisualStyleBackColor = true;
            bai_1.Click += bai_1_Click;
            // 
            // bai_2
            // 
            bai_2.Location = new Point(22, 168);
            bai_2.Name = "bai_2";
            bai_2.Size = new Size(168, 38);
            bai_2.TabIndex = 1;
            bai_2.Text = "Bài 2 ";
            bai_2.UseVisualStyleBackColor = true;
            bai_2.Click += bai_2_Click;
            // 
            // bai_3
            // 
            bai_3.Location = new Point(22, 261);
            bai_3.Name = "bai_3";
            bai_3.Size = new Size(168, 38);
            bai_3.TabIndex = 2;
            bai_3.Text = "Bài 3";
            bai_3.UseVisualStyleBackColor = true;
            bai_3.Click += bai_3_Click;
            // 
            // bai_4
            // 
            bai_4.Location = new Point(225, 131);
            bai_4.Name = "bai_4";
            bai_4.Size = new Size(168, 38);
            bai_4.TabIndex = 3;
            bai_4.Text = "Bài 4";
            bai_4.UseVisualStyleBackColor = true;
            bai_4.Click += bai_4_Click;
            // 
            // bai_5
            // 
            bai_5.Location = new Point(225, 226);
            bai_5.Name = "bai_5";
            bai_5.Size = new Size(168, 38);
            bai_5.TabIndex = 4;
            bai_5.Text = "Bài 5";
            bai_5.UseVisualStyleBackColor = true;
            bai_5.Click += bai_5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 370);
            Controls.Add(bai_5);
            Controls.Add(bai_4);
            Controls.Add(bai_3);
            Controls.Add(bai_2);
            Controls.Add(bai_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bai_1;
        private Button bai_2;
        private Button bai_3;
        private Button bai_4;
        private Button bai_5;
    }
}

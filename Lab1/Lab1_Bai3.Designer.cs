namespace Lab1
{
    partial class Lab1_Bai3
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
            label1 = new Label();
            label2 = new Label();
            textBoxSoTien = new TextBox();
            comboBoxLoaiTien = new ComboBox();
            transfer = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxKetQua = new TextBox();
            labelTyGia = new Label();
            comboBoxLoaiTien1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 0;
            label1.Text = "Chuyển đổi tiền tệ ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 1;
            label2.Text = "Số tiền cần đổi ";
            // 
            // textBoxSoTien
            // 
            textBoxSoTien.Location = new Point(130, 69);
            textBoxSoTien.Name = "textBoxSoTien";
            textBoxSoTien.Size = new Size(125, 27);
            textBoxSoTien.TabIndex = 2;
            // 
            // comboBoxLoaiTien
            // 
            comboBoxLoaiTien.FormattingEnabled = true;
            comboBoxLoaiTien.Location = new Point(284, 69);
            comboBoxLoaiTien.Name = "comboBoxLoaiTien";
            comboBoxLoaiTien.Size = new Size(161, 28);
            comboBoxLoaiTien.TabIndex = 3;
            // 
            // transfer
            // 
            transfer.Location = new Point(22, 132);
            transfer.Name = "transfer";
            transfer.Size = new Size(233, 45);
            transfer.TabIndex = 4;
            transfer.Text = "Chuyển Đổi";
            transfer.UseVisualStyleBackColor = true;
            transfer.Click += transfer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 5;
            label3.Text = "Tỷ giá quy đổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 6;
            label4.Text = "Số tiền đã đổi ";
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Location = new Point(130, 215);
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(181, 27);
            textBoxKetQua.TabIndex = 7;
            // 
            // labelTyGia
            // 
            labelTyGia.AutoSize = true;
            labelTyGia.Location = new Point(139, 279);
            labelTyGia.Name = "labelTyGia";
            labelTyGia.Size = new Size(0, 20);
            labelTyGia.TabIndex = 8;
            // 
            // comboBoxLoaiTien1
            // 
            comboBoxLoaiTien1.FormattingEnabled = true;
            comboBoxLoaiTien1.Location = new Point(330, 215);
            comboBoxLoaiTien1.Name = "comboBoxLoaiTien1";
            comboBoxLoaiTien1.Size = new Size(161, 28);
            comboBoxLoaiTien1.TabIndex = 9;
            // 
            // Lab1_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxLoaiTien1);
            Controls.Add(labelTyGia);
            Controls.Add(textBoxKetQua);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(transfer);
            Controls.Add(comboBoxLoaiTien);
            Controls.Add(textBoxSoTien);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxSoTien;
        private ComboBox comboBoxLoaiTien;
        private Button transfer;
        private Label label3;
        private Label label4;
        private TextBox textBoxKetQua;
        private Label labelTyGia;
        private ComboBox comboBoxLoaiTien1;
    }
}
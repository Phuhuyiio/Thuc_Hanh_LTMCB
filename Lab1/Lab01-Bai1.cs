using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Lab01_Bai1 : Form
    {
        public Lab01_Bai1()
        {
            InitializeComponent();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào từ textBox1
            if (!double.TryParse(textBox1.Text, out double number1))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ trong ô số 1!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
                return; // Ngừng thực hiện nếu đầu vào không hợp lệ
            }

            // Kiểm tra đầu vào từ textBox2
            if (!double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ trong ô số 2!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return; // Ngừng thực hiện nếu đầu vào không hợp lệ
            }
            if (!double.TryParse(textBox3.Text, out double number3))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ trong ô số 3!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                textBox3.SelectAll();
                return; // Ngừng thực hiện nếu đầu vào không hợp lệ
            }
            int so1 = int.Parse(textBox1.Text);
            int so2 = int.Parse(textBox2.Text);
            int so3 = int.Parse(textBox3.Text);
            int maxSo = Math.Max(so1, Math.Max(so2, so3));
            max.Text = maxSo.ToString();
            int minSo = Math.Min(so1, Math.Min(so2, so3));
            min.Text = minSo.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

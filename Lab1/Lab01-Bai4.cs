using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai4 : Form
    {
        public Lab01_Bai4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            int A, B;
            if (int.TryParse(textBox1.Text, out A) && int.TryParse(textBox2.Text, out B))
            {
                // Tính giai thừa
                long giaiThuaA = GiaiThua(A);
                long giaiThuaB = GiaiThua(B);

                // Tính tổng S1 và S2
                int S1 = Tong(A);
                int S2 = Tong(B);

                // Tính tổng S3
                double S3 = TongLuyThua(A, B);

                // Xuất kết quả
                richTextBox1.Text = $"A! = {giaiThuaA}\nB! = {giaiThuaB}\nS1 = {S1}\nS2 = {S2}\nS3 = {S3}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A và B.");
            }
        }
        private long GiaiThua(int n)
        {
            if (n == 0 || n == 1) return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private int Tong(int n)
        {
            return n * (n + 1) / 2; // Công thức tính tổng các số từ 1 đến n
        }

        private double TongLuyThua(int A, int B)
        {
            double result = 0;
            for (int i = 1; i <= B; i++)
            {
                result += Math.Pow(A, i); // Tính A^i
            }
            return result;
        }
    }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab01_Bai5 : Form
    {
        public Lab01_Bai5()
        {
            InitializeComponent();
        }

        private void AppendToExpression(string value)
        {
            ketqua.Text += value;
            lblExpression.Text = ketqua.Text;
        }

        private void number0_Click(object sender, EventArgs e) => AppendToExpression("0");
        private void number1_Click(object sender, EventArgs e) => AppendToExpression("1");
        private void number2_Click(object sender, EventArgs e) => AppendToExpression("2");
        private void number3_Click(object sender, EventArgs e) => AppendToExpression("3");
        private void number4_Click(object sender, EventArgs e) => AppendToExpression("4");
        private void number5_Click(object sender, EventArgs e) => AppendToExpression("5");
        private void number6_Click(object sender, EventArgs e) => AppendToExpression("6");
        private void number7_Click(object sender, EventArgs e) => AppendToExpression("7");
        private void number8_Click(object sender, EventArgs e) => AppendToExpression("8");
        private void number9_Click(object sender, EventArgs e) => AppendToExpression("9");
        private void dau_cham_Click(object sender, EventArgs e) => AppendToExpression(".");
        private void dau_chia_Click(object sender, EventArgs e) => AppendToExpression("/");
        private void dau_nhan_Click(object sender, EventArgs e) => AppendToExpression("*");
        private void dau_tru_Click(object sender, EventArgs e)
        {

            AppendToExpression("-");
        }
        private void dau_cong_Click(object sender, EventArgs e) => AppendToExpression("+");
        private void xoa_1_Click(object sender, EventArgs e)
        {
            if (ketqua.Text.Length > 0)
            {
                ketqua.Text = ketqua.Text.Remove(ketqua.Text.Length - 1);
            }
            lblExpression.Text = "";
        }
        private void xoa_het_Click(object sender, EventArgs e)
        {
            ketqua.Clear();
            lblExpression.Text = "";
        }




        private void dau_bang_Click(object sender, EventArgs e)
        {
            string expression = ketqua.Text;
            double result = EvaluateExpression(expression);
            ketqua.Text = result.ToString();
            
        }
        private double EvaluateExpression(string expression)
        {
            try
            {
                // Thay thế dấu cách để dễ dàng xử lý
                expression = expression.Replace(" ", "");

                // Sử dụng DataTable để thực hiện phép toán
                var result = new System.Data.DataTable().Compute(expression, null);
                return Convert.ToDouble(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình tính toán.");
                return 0;
            }
        }
    }
}


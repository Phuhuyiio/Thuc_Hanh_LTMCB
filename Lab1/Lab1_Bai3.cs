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
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
            comboBoxLoaiTien.Items.Add("USD");
            comboBoxLoaiTien.Items.Add("EUR");
            comboBoxLoaiTien.Items.Add("GBP");
            comboBoxLoaiTien.Items.Add("SGD");
            comboBoxLoaiTien.Items.Add("JPY");
            comboBoxLoaiTien.Items.Add("VND");
            comboBoxLoaiTien1.Items.Add("USD");
            comboBoxLoaiTien1.Items.Add("EUR");
            comboBoxLoaiTien1.Items.Add("GBP");
            comboBoxLoaiTien1.Items.Add("SGD");
            comboBoxLoaiTien1.Items.Add("JPY");
            comboBoxLoaiTien1.Items.Add("VND");


            // Chọn mặc định loại tiền tệ đầu tiên
            comboBoxLoaiTien.SelectedIndex = 0;
            comboBoxLoaiTien1.SelectedIndex = 5;
            comboBoxLoaiTien.SelectedIndexChanged += comboBoxLoaiTien_SelectedIndexChanged;
            comboBoxLoaiTien1.SelectedIndexChanged += comboBoxLoaiTien_SelectedIndexChanged;

            // Cập nhật tỷ giá cho loại tiền đầu tiên
            UpdateTyGia();



        }
        private void UpdateTyGia()
        {
            // Hiển thị tỷ giá tương ứng cho tiền nguồn
            string loaiTienNguon = comboBoxLoaiTien.SelectedItem.ToString();
            string loaiTienDich = comboBoxLoaiTien1.SelectedItem.ToString();
            labelTyGia.Text = $"Tỷ giá quy đổi: {GetTyGia(loaiTienNguon)} VND";

        }


        private double GetTyGia(string loaiTien)
        {
            switch (loaiTien)
            {
                case "USD":
                    return 22772;
                case "EUR":
                    return 28132;
                case "GBP":
                    return 31538;
                case "SGD":
                    return 17286;
                case "JPY":
                    return 214;
                case "VND":
                    return 1;
                default:
                    return 0;
            }
        }
        private void comboBoxLoaiTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTyGia();
        }
        private void transfer_Click(object sender, EventArgs e)
        {
            // Lấy số tiền từ TextBox
            double soTien;
            bool isNumber = double.TryParse(textBoxSoTien.Text, out soTien);

            if (isNumber && soTien > 0)
            {
                // Lấy loại tiền tệ nguồn và đích
                string loaiTienNguon = comboBoxLoaiTien.SelectedItem.ToString();
                string loaiTienDich = comboBoxLoaiTien1.SelectedItem.ToString();

                // Lấy tỷ giá của tiền tệ nguồn và đích
                double tiGiaNguon = GetTyGia(loaiTienNguon);
                double tiGiaDich = GetTyGia(loaiTienDich);

                // Chuyển đổi từ loại tiền tệ nguồn sang loại tiền tệ đích
                double soTienQuyDoi = (soTien * tiGiaNguon) / tiGiaDich;

                // Hiển thị kết quả
                textBoxKetQua.Text = soTienQuyDoi.ToString("N2") + " " + loaiTienDich;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
            }
        }
    }
}

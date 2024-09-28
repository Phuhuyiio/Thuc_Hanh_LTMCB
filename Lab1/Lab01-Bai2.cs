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
    public partial class Lab01_Bai2 : Form
    {
        public Lab01_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị nhập từ TextBox
            int soNhap;
            bool isNumber = int.TryParse(nhap_so.Text, out soNhap);

            if (isNumber && soNhap >= 0 && soNhap <= 9)
            {
                // Dùng switch để hiển thị số bằng chữ
                string soBangChu;
                switch (soNhap)
                {
                    case 0:
                        soBangChu = "Không";
                        break;
                    case 1:
                        soBangChu = "Một";
                        break;
                    case 2:
                        soBangChu = "Hai";
                        break;
                    case 3:
                        soBangChu = "Ba";
                        break;
                    case 4:
                        soBangChu = "Bốn";
                        break;
                    case 5:
                        soBangChu = "Năm";
                        break;
                    case 6:
                        soBangChu = "Sáu";
                        break;
                    case 7:
                        soBangChu = "Bảy";
                        break;
                    case 8:
                        soBangChu = "Tám";
                        break;
                    case 9:
                        soBangChu = "Chín";
                        break;
                    default:
                        soBangChu = "Không hợp lệ";
                        break;
                }

                // Hiển thị kết quả trong TextBox kết quả
                ket_qua.Text = soBangChu;
            }
            else
            {
                // Hiển thị lỗi nếu giá trị nhập không hợp lệ
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9.");
            }
        }
    }
    }


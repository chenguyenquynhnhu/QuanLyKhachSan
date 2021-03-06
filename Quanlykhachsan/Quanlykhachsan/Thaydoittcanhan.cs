using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;


namespace Quanlykhachsan
{
    public partial class Thaydoittcanhan : Form
    {
        public Thaydoittcanhan()
        {
            InitializeComponent();
        }
        bool tam = false;
        private void Thaydoittcanhan_Load(object sender, EventArgs e)
        {

            txtmanhanvien.Text = KTdangnhap.strmanhanvien;
            txtquyenhan.Text = KTdangnhap.strquyenhan;
            txttendangnhap.Text = KTdangnhap.strnguoidung;
            txthoten.Text = KTdangnhap.strhoten;
            txtdiachi.Text = KTdangnhap.strdiachi;
        }

        private void btthongtin_Click(object sender, EventArgs e)
        {
            if (tam == false)
            {
                txtdiachi.Enabled = txthoten.Enabled = txttendangnhap.Enabled = true;
                tam = true;
                btthongtin.Text = "OK";
            }
            else
            {
                KTdangnhap.strdiachi = txtdiachi.Text;
                KTdangnhap.strhoten = txthoten.Text;
                KTdangnhap.strnguoidung = txttendangnhap.Text;
                Lnhanvien nv = new Lnhanvien(KTdangnhap.strmanhanvien, KTdangnhap.strhoten, KTdangnhap.strdiachi, KTdangnhap.strquyenhan, KTdangnhap.strnguoidung, KTdangnhap.strmatkhau);
                if (nv.capnhat() == true)
                {
                    txtdiachi.Enabled = txthoten.Enabled = txttendangnhap.Enabled = false;
                    tam = false;
                    btthongtin.Text = "Thay đổi thông tin";
                    MessageBox.Show("Đã cập nhật thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại bạn hãy thử lại", "Thông báo");
                }

            }
        }

        private void btmatkhau_Click(object sender, EventArgs e)
        {

            thaydoimk fr = new thaydoimk();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
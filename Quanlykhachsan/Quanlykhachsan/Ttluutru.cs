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
    public partial class Ttluutru : Form
    {
        public Ttluutru()
        {
            InitializeComponent();
        }
        
        private void Ttluutru_Load(object sender, EventArgs e)
        {
            DataSet ds;
            try
            {
                laydulieu dl = new laydulieu();
                //string strcom = "select makhach from khachhang";
                
                SqlDataReader rd = dl.lay_reader("SELECT checkin.macheckin, checkin.makhach, khachhang.phongdon, khachhang.phongdoi FROM checkin INNER JOIN khachhang ON checkin.makhach = khachhang.makhach");
                //
                //SqlDataReader rd2=dl.lay_reader("select soluong from loaiphong,phong where 
                while (rd.Read())
                {

                    cb1.Items.Add(rd.GetString(0) + "-" + rd.GetString(1) + "-" + rd.GetValue(2).ToString() + " phòng đơn" + "-" + rd.GetValue(3).ToString()+" Phòng đôi");
                    cb1.DropDownStyle = ComboBoxStyle.DropDownList;
                    
                }
                rd.NextResult();
                rd.Close();

                ds = dl.getdata("select * from phong where tinhtrang='empty'");
                dataGridView1.DataSource = ds.Tables[0];
              
            }
            catch 
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcom1 = "Update checkin set sophong='" + tphong.Text + "' where macheckin='" + cb1.SelectedItem.ToString().Substring(0,cb1.SelectedItem.ToString().IndexOf("-")) + "'";
            string strcom2 = "Update phong set tinhtrang='Reserve' where sophong='" + tphong.Text + "'";

            string strcom3 = "Update luutru set sophong='" + tphong.Text + "' where macheckin='" + cb1.SelectedItem.ToString().Substring(0, cb1.SelectedItem.ToString().IndexOf("-")) + "'";
            try
            {
                ketnoi.ThietlapketNoi();
                //laydulieu dl = new laydulieu();
                //if ( dl.thucthitruyvan("insert into checkin values(" + tcheckin.Text + "," + tmakhach.Text + "," + tphong.Text + ")") == 1 && dl.thucthitruyvan("Update from phong set tinhtrang='Reserve' where sophong=" + tphong.Text) == 1)
                SqlCommand com1 = new SqlCommand(strcom1, ketnoi.con);
                SqlCommand com2 = new SqlCommand(strcom2, ketnoi.con);
                SqlCommand com3 = new SqlCommand(strcom3, ketnoi.con);

                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();
                //label2.Text = cb1.SelectedItem.ToString().Substring(0, cb1.SelectedItem.ToString().IndexOf("-"));


                MessageBox.Show("Đã lưu trữ thành công", "Thông báo");
                ketnoi.HuyKetNoi();
            }
            catch { }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
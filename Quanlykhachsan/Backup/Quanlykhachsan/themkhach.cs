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
    public partial class themkhach : Form
    {
        string tam;
        public themkhach()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        string maluutru()
        {
            laydulieu dl = new laydulieu();
            string tam1 = "";
            int i = 0;
            SqlDataReader dr = dl.lay_reader("select maluutru from luutru");
            while (dr.Read())
                tam1 = dr[0].ToString();
            ketnoi.HuyKetNoi();
            i = int.Parse(tam1.Substring(2, tam1.Length - 2));
            i++;
            if (i < 10) return ("LT00" + i.ToString());
            else
                if (i < 100) return ("LT0" + i.ToString());
                else return ("LT" + i.ToString());
        }
        string makhach()
        {
            laydulieu dl = new laydulieu();
            string tam1 = "";
            int i = 0;
            SqlDataReader dr = dl.lay_reader("select makhach from khachhang");
            while (dr.Read())
                tam1 = dr[0].ToString();
            ketnoi.HuyKetNoi();
            i = int.Parse(tam1.Substring(2, tam1.Length - 2));
            i++;
            if (i < 10) return "KH00" + i.ToString();
            else
                if (i < 100) return "KH0" + i.ToString();
                else return "KH" + i.ToString();
        }
        string macheckin()
        {
            laydulieu dl = new laydulieu();
            string tam1 = "";
            int i = 0;
            SqlDataReader dr = dl.lay_reader("select macheckin from checkin");
            while (dr.Read())
                tam1 = dr[0].ToString();
            ketnoi.HuyKetNoi();
            i = int.Parse(tam1.Substring(2, tam1.Length - 2));
            i++;
            if (i < 10) return "CK00" + i.ToString();
            else
                if (i < 100) return "CK0" + i.ToString();
                else return "CK" + i.ToString();
        }


        private void themkhach_Load(object sender, EventArgs e)
        {  //string mkhach=makhach();
            //string mcheckin=macheckin();
            //string mlu=maluutru();
            try
            {
                //ketnoi.strcon += Dangnhap.strtensv;
                tngaydat.Text = System.DateTime.Now.ToString();
                tmakhach.Text = makhach();
                tcheckin.Text = macheckin();
                //label16.Text = maluutru();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
    
           

        private void button1_Click(object sender, EventArgs e)
        {
            string luutru=maluutru();
            int tuoi,phongdon,phongdoi,thue;
            if (tmakhach.Text == "")
                MessageBox.Show("Hãy nhập vào mã khách hàng", "Chú ý");
            if (ttenkhach.Text == "")
                MessageBox.Show("Hãy nhập vào tên khách hàng", "Chú ý");

            if (ttuoi.Text == "") tuoi = 0;

            else tuoi = Convert.ToInt16(ttuoi.Text);

            if (tphongdon.Text == "") phongdon = 0;

            else phongdon = Convert.ToInt16(tphongdon.Text);

            if (tphongdoi.Text == "") phongdoi = 0;
            else phongdoi = Convert.ToInt16(tphongdoi.Text);

            if (ttgianthue.Text == "") thue = 0;

            else thue = Convert.ToInt16(ttgianthue.Text);



            
            string strcom1="insert into khachhang values(" +"'"+tmakhach.Text + "'," +"'"+ttenkhach.Text+"',"+ tuoi + "," + "'"+tam + "'," +"'"+ tquoctich.Text + "'," + "'"+tcmnd.Text + "'," + "'"+tdienthoai.Text + "'," + "'"+tdiachi.Text + "'," + "'"+tngaydat.Text + "',"+thue+","+phongdon+","+phongdoi+",'"+comboBox1.SelectedItem.ToString()+"')";
            string strcom2 = "insert into checkin(macheckin,makhach) values('" + tcheckin.Text + "','"+ tmakhach.Text + "')";
            string strcom3 = "insert into luutru(maluutru,macheckin,makhach) values('" + luutru + "','" + tcheckin.Text + "','" + tmakhach.Text + "')";
            DataSet dt;
            
            //string tam1; 
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
                //label16.Text = luutru;
                
                 MessageBox.Show("Đã thêm khách hàng vào CSDL", "Thông báo");
                    ketnoi.HuyKetNoi() ;

                    /*laydulieu dl = new laydulieu();
                    dt = dl.getdata("select sophong from phong where tinhtrang='Reserve'");
                    
                
                tam1=dt.Tables[0].Rows[0]["sophong"].ToString();
                    if (tam.IndexOf(tphongdon.Text) >= 0)
                        MessageBox.Show("Phòng này đã có khách đặt", "Chú ý");*/




                  

                }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tam = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tam = "Female";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmakhach.Text = makhach();
            tcheckin.Text = macheckin();
            tcmnd.Text = "";
            tdiachi.Text = "";
            tdienthoai.Text = "";
            tquoctich.Text = "";
            tphongdoi.Text = "";
            tphongdon.Text = "";
            ttuoi.Text = "";
            ttenkhach.Text = "";
            ttgianthue.Text = "";
            


        }
    }
}
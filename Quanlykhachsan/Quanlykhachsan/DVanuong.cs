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
    public partial class DVanuong : Form
    {
        public DVanuong()
        {
            InitializeComponent();
        }
       
        string[] s = new string[50];
        //int i=0;
        DataSet ds = new DataSet();
        
       
          
       
       

       /* private void button1_Click(object sender, EventArgs e)
        {
            laydulieu dl = new laydulieu();
            ds=dl.getdata("select * from dichvuanuong");
            if (dl.thucthitruyvan("insert into dichvuanuong values ('"+taoma(s[ds.Tables[0].Rows.Count-1]),
        }*/

        private void DVanuong_Load(object sender, EventArgs e)
        {
            laydulieu dl = new laydulieu();
            SqlDataReader rd = dl.lay_reader("select macheckin from checkin");
            while (rd.Read())
            {
                comboBox1.Items.Add(rd.GetString(0));

            }
            rd.NextResult();
            
            rd.Close();
            



            SqlDataReader rd2 = dl.lay_reader("select mamonan,tenmonan from monan");

            while (rd2.Read())
            {
                comboBox2.Items.Add(rd2.GetString(0) + "-" + rd2.GetString(1));
            }
            rd2.NextResult();
            rd2.Close();
           
           
            ds = dl.getdata("select * from dichvuanuong");
            
            DataColumn[] dt = new DataColumn[1];
            dt[0] = ds.Tables[0].Columns[0];
            //ds.Tables[0].PrimaryKey = dt;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listView1.Items.Add(ds.Tables[0].Rows[i]["macheckin"].ToString(), 1);
                listView1.Items[i].SubItems.Add(ds.Tables[0].Rows[i]["mamonan"].ToString());
                listView1.Items[i].SubItems.Add(ds.Tables[0].Rows[i]["ngay"].ToString());
                listView1.Items[i].SubItems.Add(ds.Tables[0].Rows[i]["gia"].ToString());
                //s[i] = ds.Tables[0].Rows[i]["manhanvien"].ToString();

            }

            tngay.Text=System.DateTime.Now.ToString();
            //label5.Text = comboBox2.SelectedItem.ToString().Substring(0, comboBox2.SelectedItem.ToString().IndexOf("--"));

        }
        string taoma()
        {
            laydulieu dl = new laydulieu();
            string tam1 = "";
            int i = 0;
            SqlDataReader dr = dl.lay_reader("select madichvuanuong from dichvuanuong");
            while (dr.Read())
                tam1 = dr[0].ToString();
            ketnoi.HuyKetNoi();
            i = int.Parse(tam1.Substring(2, tam1.Length - 2));
            i++;
            if (i < 10) return "AU00" + i.ToString();
            else
                if (i < 100) return "AU0" + i.ToString();
                else return "AU" + i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcom="insert into dichvuanuong(madichvuanuong,mamonan,ngay,macheckin,gia) values('"+taoma()+"','"+comboBox2.SelectedItem.ToString().Substring(0, comboBox2.SelectedItem.ToString().IndexOf("-"))+"','"+tngay.Text+"','"+comboBox1.SelectedItem.ToString()+"','"+Convert.ToInt32(tgiatien.Text)+"')";
           
            //laydulieu dl = new laydulieu();
        

            
            try
            {
                ketnoi.ThietlapketNoi();
                SqlCommand com = new SqlCommand(strcom, ketnoi.con);
                com.ExecuteNonQuery();
                int i = ds.Tables[0].Rows.Count;
              
              
                
                //ds= dl.getdata("select macheckin,mamonan,ngay,gia from dichvuanuong");
                

                //---Cập nhat thong tin cho listview
                  

                listView1.Items.Add(comboBox1.SelectedItem.ToString(),1);
                listView1.Items[i].SubItems.Add(comboBox2.SelectedItem.ToString().Substring(0, comboBox2.SelectedItem.ToString().IndexOf("-")));
                listView1.Items[i].SubItems.Add(tngay.Text);
                listView1.Items[i].SubItems.Add(tgiatien.Text);
                 MessageBox.Show("Đã thêm thành công","Thông báo");
                   

            }
            catch (Exception ex) {
               MessageBox.Show(ex.Message);
            }


        }

        private void tsoluong_TextChanged(object sender, EventArgs e)
        {

            float tong;
            laydulieu dl = new laydulieu();
           
           SqlDataReader rd = dl.lay_reader("select gia from monan where mamonan='" + comboBox2.SelectedItem.ToString().Substring(0, comboBox2.SelectedItem.ToString().IndexOf("-")) + "'");
           while (rd.Read())
           {

               tong = Convert.ToInt32(rd.GetValue(0)) * Convert.ToInt32(tsoluong.Text);

               tgiatien.Text = tong.ToString();
           }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
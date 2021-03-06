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
    public partial class Phanquyen : Form
    {
        public Phanquyen()
        {
            InitializeComponent();
        }
        SqlDataReader dr;
        //bool tam = true;

        private void button4_Click(object sender, EventArgs e)
        {
            string str = treeView1.SelectedNode.Tag.ToString();
            if (str != "Ro")
            {
                /*if (tam)
                {
                    //listView1.Enabled = true;
                    tam = false;
                    //button1.Text = "OK";
                }
             
                else
                {*/
                    string st = "";
                    for (int i = 0; i < listView1.CheckedItems.Count; i++)
                        st = st + listView1.CheckedItems[i].Text;
                    //MessageBox.Show(st);
                    if (st != "")
                    {
                        Lnhanvien nv = new Lnhanvien();
                        nv.set_manhanvien(txtmanhanvien.Text);
                        //nv.set_matkhau("");
                        nv.set_diachi(txtdiachi.Text);
                        nv.set_hoten(txthoten.Text);
                        //nv.set_quyenhan(cb1.Text);
                        nv.set_tendangnhap(txttendangnhap.Text);
                        nv.set_manhanvien(str.Substring(1, str.Length - 1));
                        if (st.IndexOf("ADMIN") >= 0)
                            nv.nangquyen("ADMIN");
                        else
                            nv.nangquyen(st);
                        nv.capnhat();
                        //button1.Text = "Cập Nhật";
                        //tam = true;
                        //listView1.Enabled = false;
                        MessageBox.Show("Đã thực hiện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    //else
                    //{
                        //MessageBox.Show("Hãy kiểm tra lại giá trị quyền hạn", "Thông báo");
                    //}
                }
            
            else
            {
                MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Phanquyen_Load(object sender, EventArgs e)
        {
            laydulieu dl = new laydulieu();
            TreeNode n = new TreeNode();
            n.Tag = "Ro";
            n.Text = "Danh sach nhân viên";
            n.ImageIndex = 0;
            treeView1.Nodes.Add(n);
            dr = dl.lay_reader("select tendangnhap,manhanvien,diachi from nhanvien");

            while (dr.Read())
            {
                TreeNode tn = new TreeNode();
                tn.Tag = "E" + dr[1].ToString();
                tn.Text = dr[0].ToString();
                tn.ImageIndex = 1;
                n.Nodes.Add(tn);
            }
            ketnoi.HuyKetNoi();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items[0].Checked = false;
            listView1.Items[1].Checked = false;
            listView1.Items[2].Checked = false;
            //listView1.Items[3].Checked = false;
            string str = treeView1.SelectedNode.Tag.ToString();
            if (str != "Ro")
            {
                laydulieu dl = new laydulieu();
                SqlDataReader dr = dl.lay_reader("select tendangnhap,manhanvien,hoten,quyenhan,diachi from nhanvien where manhanvien='" + str.Substring(1, str.Length - 1) + "'");
                while (dr.Read())
                {
                    txthoten.Text = dr[2].ToString();
                    txtmanhanvien.Text = dr[1].ToString();
                    txttendangnhap.Text = dr[0].ToString();
                    txtdiachi.Text = dr[4].ToString();
                    if (dr[3].ToString().Trim() == "ADMIN") listView1.Items[2].Checked = true;
                    else
                    {
                        if (dr[3].ToString().IndexOf("NHANVIEN") >= 0) listView1.Items[0].Checked = true;
                        //if (dr[3].ToString().IndexOf("MUONTRA") >= 0) listView1.Items[1].Checked = true;
                        if (dr[3].ToString().IndexOf("QUANLY") >= 0) listView1.Items[1].Checked = true;
                    }

                }
                ketnoi.HuyKetNoi();
            }
        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;
using System.Data;
using System.Windows.Forms;

namespace Quanlykhachsan.Lopdoituong
{
    public class KTbangKH
    {
        public static bool kt_trungmaKH(string maKH)
        {
            try
            {
                KTbangKH P = new KTbangKH();
                DataSet ds1 = new DataSet();

                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();

                ds1 = dl.getdata("select * from khachhang where makhach = '" + maKH + "' ");
                if (ds1.Tables[0].Rows.Count == 0) { ketnoi.HuyKetNoi(); return false; }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Chú ý");
                    ketnoi.HuyKetNoi();
                    return true;
                }


                //ds1 = dl.getdata("insert into khachhang(makhach)values('" + maKH + "')");
                //return true;

                //if (ktmaKH == false)
                //{
                //    MessageBox.Show("Mã khách hàng đã tồn tại!", "Chú ý");

                //};


                //ds1 = dl.getdata("select * from khachhang where makhach ='" + maKH + "'");
                //if (ds1.Tables[0].Rows.Count == 0)
                //    return true;
                //else
                //    MessageBox.Show("Mã khách hàng đã tồn tại!", "Chú ý");


            }
            catch { return false; }
        }
    }
}

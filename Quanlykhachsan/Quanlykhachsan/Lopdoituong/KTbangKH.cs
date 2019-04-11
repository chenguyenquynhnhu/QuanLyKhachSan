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
                

            }
            catch { return false; }
        }

        public static bool kt_nhaptuoi(string tuoi)
        {
            try
            {

                DataSet ds1 = new DataSet();

                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into khachhang(tuoi)values('" + tuoi + "')");
                MessageBox.Show("Nhập tuổi dạng số!", "Chú ý");
                return true;
            }
            catch { return false; }
        }

        //public static bool kt_KhongTrungMaKHvaMacheckin(string maKH, string macheckin)
        //{
        //    try
        //    {
        //        KTbangKH P = new KTbangKH();
        //        DataSet ds1 = new DataSet();

        //        ketnoi.ThietlapketNoi();
        //        laydulieu dl = new laydulieu();

        //        ds1 = dl.getdata("select * from khachhang where makhach = '" + maKH + "' ");
        //        if ((ds1.Tables[0].Rows.Count == 0) && (KTbangCheckin.kt_trungmacheckin(macheckin))) { ketnoi.HuyKetNoi(); return false; }
        //        else return true;


        //    }
        //    catch { return false; }
        //}
    }
}

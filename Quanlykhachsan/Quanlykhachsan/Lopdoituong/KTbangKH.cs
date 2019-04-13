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
        public static bool kt_ThemKhachBoTrongMaKH(string maKH)
        {
            try
            {
                if (maKH == "")
                {
                    MessageBox.Show("Hãy nhập vào mã khách hàng", "Chú ý");
                    return false;
                }
                return true;
            }
            catch { return true; }
        }

        public static bool kt_ThemKhachBoTrongTenKH(string tenKH)
        {
            try
            {
                if (tenKH == "")
                {
                    MessageBox.Show("Hãy nhập vào tên khách hàng", "Chú ý");
                    return false;
                }
                return true;
            }
            catch { return true; }
        }

        public static bool kt_trungmaKH(string maKH)
        {
            try
            {
                DataSet ds1 = new DataSet();

                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();

                ds1 = dl.getdata("select * from khachhang where makhach = '" + maKH + "' ");
                if (ds1.Tables[0].Rows.Count == 0) { ketnoi.HuyKetNoi(); return true; }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại!", "Chú ý");
                    ketnoi.HuyKetNoi();
                    return false;
                }
                

            }
            catch { return true; }
        }

       
        public static bool kt_nhaptuoi(string tuoi)
        {
            try
            {
                if (tuoi == "")
                {
                    return true;
                }
               
                    
                DataSet ds1 = new DataSet();
                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
               
                ds1 = dl.getdata("insert into khachhang(tuoi)values('" + tuoi + "')");
                return false;
            }
            catch {
                return true; }
        }

        public static bool kt_nhapSoPhongDoi(string SoPhongDoi)
        {
            try
            {
                if (SoPhongDoi == "")
                {
                    return true;
                }
                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into khachhang(phongdon)values('" + SoPhongDoi + "')");
                return false;

            }
            catch { return true; }
        }

        public static bool kt_nhapSoPhongDon(string SoPhongDon)
        {
            try
            {
                if (SoPhongDon == "")
                {
                    return true;
                }
                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into khachhang(phongdon)values('" + SoPhongDon + "')");
                return false;

            }
            catch { return true; }
        }

        public static bool kt_nhapTGThue(string TGThue)
        {
            try
            {
                if (TGThue == "")
                {
                    return true;
                }
                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into khachhang(songay)values('" + TGThue + "')");
                return false;

            }
            catch { return true; }
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

        //public static bool kt_ThemKhachDayDutt(string maKH, string tenKH, string tuoi, string gioitinh, string quoctich, string cmnd, string dt, string diachi, string ngaydat, string tgthue, string phongdon, string phongdoi, string loaiphong)
        //{
        //    try
        //    {
        //        DataSet ds1 = new DataSet();

        //        ketnoi.ThietlapketNoi();
        //        laydulieu dl = new laydulieu();
        //        ds1 = dl.getdata("insert into khachhang values(" + "'" + maKH + "'," + "'" + tenKH + "'," + tuoi + "," + "'" + gioitinh + "'," + "'" + quoctich + "'," + "'" + cmnd + "'," + "'" + dt + "'," + "'" + diachi + "'," + "'" + ngaydat + "'," + tgthue + "," + phongdon + "," + phongdoi + ",'" + loaiphong + "')");
        //        MessageBox.Show("Đã thêm khách hàng thành công", "Thông báo");
        //        ketnoi.HuyKetNoi();
        //        return true;
        //    }
        //    catch { return false; }
        //}
    }
}

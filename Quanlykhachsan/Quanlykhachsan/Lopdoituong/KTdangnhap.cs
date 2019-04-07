using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;

namespace Quanlykhachsan.Lopdoituong
{
    public class KTdangnhap
    {
        private DataSet ds;
        public static string strquyenhan = "", strnguoidung = "", strhoten = "", strdiachi = "", strmanhanvien = "", strmatkhau = "";
        private string v1;
        private string v2;

        public static bool kt_dangnhap(string ten, string matkhau)
        {
            //Lnhanvien nv = new Lnhanvien();
            try
            {
                KTdangnhap P = new KTdangnhap();
                DataSet ds1 = P.ds;


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("select * from nhanvien where matkhau = '" + matkhau + "' and tendangnhap = '" + ten + "'");
                if (ds1.Tables[0].Rows.Count == 0) { ketnoi.HuyKetNoi(); return false; }
                else
                {
                    strmanhanvien = ds1.Tables[0].Rows[0]["manhanvien"].ToString();
                    strhoten = ds1.Tables[0].Rows[0]["hoten"].ToString();
                    strdiachi = ds1.Tables[0].Rows[0]["diachi"].ToString();
                    strnguoidung = ds1.Tables[0].Rows[0]["tendangnhap"].ToString();
                    strquyenhan = ds1.Tables[0].Rows[0]["quyenhan"].ToString();


                    strmatkhau = ds1.Tables[0].Rows[0]["matkhau"].ToString();
                    ketnoi.HuyKetNoi();
                    return true;
                }
            }
            catch { return false; }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;
using System.Data;
using System.Windows.Forms;
namespace Quanlykhachsan.Lopdoituong
{
    public class KTbangLuuTru
    {
        public static bool kt_nhapSoPhong(string SoPhong)
        {
            try
            {
                if (SoPhong == "")
                {
                    return true;
                }
                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into luutru(phongdon)values('" + SoPhong + "')");
                return false;

            }
            catch { return true; }
        }
    }
}

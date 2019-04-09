using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;
using System.Data;

namespace Quanlykhachsan.Lopdoituong
{
    public class KTNhapTuoi
    {
        public static bool kt_nhaptuoi(string tuoi)
        {
            try
            {

                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into khachhang(tuoi)values('" + tuoi + "')");
                return false;

            }
            catch { return true; }
        }
    }
}

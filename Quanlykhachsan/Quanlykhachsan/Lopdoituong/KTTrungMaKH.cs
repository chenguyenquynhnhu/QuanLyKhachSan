using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;
using System.Data;

namespace Quanlykhachsan.Lopdoituong
{
    public class KTTrungMaNV
    {
        public static bool kt_trungmaKH(string maKH)
        {
            try
            {

                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into khachhang(makhach)values('" + maKH + "')");
                return false;

            }
            catch { return true; }
        }
    }
}

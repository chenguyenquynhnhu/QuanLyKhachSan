using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;
using System.Data;

namespace Quanlykhachsan.Lopdoituong
{
    public class KTTrungMaCheckin
    {
        public static bool kt_trungmacheckin(string macheckin)
        {
            try
            {

                DataSet ds1 = new DataSet();


                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();
                ds1 = dl.getdata("insert into checkin(macheckin)values('" + macheckin + "')");
                return false;

            }
            catch { return true; }
        }
    }
}
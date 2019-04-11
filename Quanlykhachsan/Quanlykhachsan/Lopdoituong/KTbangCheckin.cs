using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Quanlykhachsan.Lopdoituong;
using System.Data;
using System.Windows.Forms;

namespace Quanlykhachsan.Lopdoituong
{
    public class KTbangCheckin
    {
        public static bool kt_trungmacheckin(string macheckin)
        {
            try
            {
                
                DataSet ds1 = new DataSet();

                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();

                ds1 = dl.getdata("select * from checkin where macheckin = '" + macheckin + "' ");
                if (ds1.Tables[0].Rows.Count == 0) { ketnoi.HuyKetNoi(); return false; }
                else
                {
                    MessageBox.Show("Mã check in đã tồn tại!", "Chú ý");
                    ketnoi.HuyKetNoi();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}
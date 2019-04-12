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
        public static bool kt_ThemKhachBoTrongMacheckin(string macheckin)
        {
            try
            {
                if (macheckin == "")
                {
                  MessageBox.Show("Hãy nhập vào mã check in", "Chú ý");
                  return false;
                }
                return true;
            }
            catch { return true; }
        }

        public static bool kt_trungmacheckin(string macheckin)
        {
            try
            {
                
                DataSet ds1 = new DataSet();

                ketnoi.ThietlapketNoi();
                laydulieu dl = new laydulieu();

                ds1 = dl.getdata("select * from checkin where macheckin = '" + macheckin + "' ");
                if (ds1.Tables[0].Rows.Count == 0) { ketnoi.HuyKetNoi(); return true; }
                else
                {
                    MessageBox.Show("Mã check in đã tồn tại!", "Chú ý");
                    ketnoi.HuyKetNoi();
                    return false;
                }
            }
            catch { return true; }
        }
    }
}
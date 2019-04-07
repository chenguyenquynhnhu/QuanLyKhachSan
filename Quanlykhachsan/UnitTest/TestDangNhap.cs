using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;


namespace UnitTest
{
    [TestClass]
    public class TestDangNhap
    {
        //private KTdangnhap nv;

        [TestMethod]
        public void DangNhapThanhCong()
        {
            bool actual = KTdangnhap.kt_dangnhap("admin", "admin");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DangNhapSaiMatKhau()
        {
            bool actual = KTdangnhap.kt_dangnhap("admin", "admin123");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


    }
}

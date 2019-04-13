using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;

namespace UnitTest
{
    [TestClass]
    public class TestbangLuuTru
    {
        [TestMethod]
        public void Test_NhapSoPhongKhongPhaiDangSo()
        {
            bool actual = KTbangLuuTru.kt_nhapSoPhong("hai");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}

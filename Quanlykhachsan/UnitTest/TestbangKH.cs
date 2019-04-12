using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;

namespace UnitTest
{
    [TestClass]
    public class TestbangKH
    {
        [TestMethod]
        public void Test_KhongNhapMaKH()
        {
            bool actual = KTbangKH.kt_ThemKhachBoTrongMaKH("");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_KhongNhapTenKH()
        {
            bool actual = KTbangKH.kt_ThemKhachBoTrongTenKH("");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_trungmaKH()
        {
            bool actual = KTbangKH.kt_trungmaKH("KH001");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_NhapTuoiKphaiDangSo()
        {
            bool actual = KTbangKH.kt_nhaptuoi("hai");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Test_KhongNhapTenKH()
        //{
        //    bool actual = KTbangKH.kt_trungmaKH("KH001");
        //    bool expected = true;
        //    Assert.AreEqual(expected, actual);
        //}
    }
}

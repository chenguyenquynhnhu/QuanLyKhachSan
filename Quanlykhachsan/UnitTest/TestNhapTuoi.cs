using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;

namespace UnitTest
{
    [TestClass]
    public class TestNhapTuoi
    {
        [TestMethod]
        public void Test_NhapTuoiKphaiDangSo()
        {
            bool actual = KTNhapTuoi.kt_nhaptuoi("hai");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}

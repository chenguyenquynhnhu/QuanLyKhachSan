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
        public void Test_trungmaKH()
        {
            bool actual = KTbangKH.kt_trungmaKH("KH001");
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}

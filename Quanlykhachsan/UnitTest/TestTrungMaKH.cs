using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;

namespace UnitTest
{
    [TestClass]
    public class TestTrungMaKH
    {
        [TestMethod]
        public void Test_trungmaKH()
        {
            bool actual = KTTrungMaKH.kt_trungmaKH("KH001");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}

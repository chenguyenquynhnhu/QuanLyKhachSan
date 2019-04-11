using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;


namespace UnitTest
{
    [TestClass]
    public class TestbangCheckin
    {
        [TestMethod]
        public void test_trungmacheckin()
        {
            bool actual = KTbangCheckin.kt_trungmacheckin("CK001");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}

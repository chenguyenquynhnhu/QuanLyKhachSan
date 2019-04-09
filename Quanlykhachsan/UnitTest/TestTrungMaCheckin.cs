using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;
using System.Windows;


namespace UnitTest
{
    [TestClass]
    public class TestTrungMaCheckin
    {
        [TestMethod]
        public void test_trungmacheckin()
        {
            bool actual = KTTrungMaCheckin.kt_trungmacheckin("CK01");
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}

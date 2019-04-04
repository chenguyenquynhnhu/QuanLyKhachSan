using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Quanlykhachsan;
using Quanlykhachsan.Lopdoituong;

namespace UnitTest
{
    [TestClass]
    public class TestDangNhap
    {
        private KTdangnhap nv;

        //public TestContext TestContest { get; set; }
        [TestInitialize]
        public void SetUp()
        {
            nv.ten = "admin";
            nv.matkhau = "admin";
        }

        [TestMethod]
        public void DangNhapThanhCong()
        {
            bool actual = nv.kt_dangnhap();

            Assert.IsFalse(actual);
        }

        //[TestMethod]
        //public void TestDataDriven()
        //{

        //}

    }
}

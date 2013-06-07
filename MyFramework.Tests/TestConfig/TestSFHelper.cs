using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Tests.Base;
using NUnit.Framework;
using MyFramework.Service.Util;

namespace MyFramework.Tests.TestConfig
{
    public class TestSFHelper :LogCase
    {
        /// <summary>
        /// 生成数据库表结构
        /// </summary>
        [Test]
        public void TestGenerateDatabaseSchema()
        {
            var sfCorporate = SFHelper.SfCorporate;
            Assert.NotNull(sfCorporate);

            var sfCompany = SFHelper.SfCompanyMain;
            Assert.NotNull(sfCompany);

            var sfCompanyReport = SFHelper.SfCompanyReport;
            Assert.NotNull(sfCompanyReport);



            log.Info("完成");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Tests.Base;
using NUnit.Framework;
using MyFramework.Service.Util;
using MyFramework.Common.NHibernate.Domain;

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

        [Test]
        public void TestGenerateRecords()
        {
            using (var session = SFHelper.SfCorporate.OpenSession())
            using (var tran = session.BeginTransaction())
            {

                var product = new Product { Category = "水果" };
                product.Name = "苹果机构";
                product.Price = 3.1415926M;
                session.Save(product);

                tran.Commit();
            }
            /************  company main   ***********/
            using (var session = SFHelper.SfCompanyMain.OpenSession())
            using (var tran = session.BeginTransaction())
            {

                var product = new Product { Category = "水果" };
                product.Name = "苹果公司";
                product.Price = 3.1415926M;
                session.Save(product);

                tran.Commit();
            }
            /************ company report  ***********/
            using (var session = SFHelper.SfCompanyReport.OpenSession())
            using (var tran = session.BeginTransaction())
            {

                var product = new Product { Category = "水果" };
                product.Name = "苹果公司报表";
                product.Price = 3.1415926M;
                session.Save(product);

                tran.Commit();
            }
            log.Info("完成");
        }
    }
}

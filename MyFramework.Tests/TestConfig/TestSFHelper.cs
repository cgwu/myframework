using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Tests.Base;
using NUnit.Framework;
using MyFramework.Service.Util;
using MyFramework.Common.NHibernate.Domain;
using System.Transactions;

namespace MyFramework.Tests.TestConfig
{
    public class TestSFHelper :LogCase
    {
        /// <summary>
        /// 生成数据库表结构
        /// </summary>
        [Test]
        public void TestGenerateDatabaseSchemaCorporate()
        {
            var sfCorporate = SFHelper.SfCorporate;
            Assert.NotNull(sfCorporate);

            //var sfCompany = SFHelper.SfCompanyMain;
            //Assert.NotNull(sfCompany);

            //var sfCompanyReport = SFHelper.SfCompanyReport;
            //Assert.NotNull(sfCompanyReport);

            log.Info("完成");
        }

        [Test]
        public void TestGenerateDatabaseSchemaCompany()
        {

            var sfCompany = SFHelper.SfCompanyMain;
            Assert.NotNull(sfCompany);

            log.Info("完成");
        }

        [Test]
        public void TestGenerateDatabaseSchemaCompanyReport()
        {
            var sfCompanyReport = SFHelper.SfCompanyReport;
            Assert.NotNull(sfCompanyReport);

            log.Info("完成");
        }



        /// <summary>
        /// 多个数据库分别事务
        /// </summary>
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




        /// <summary>
        /// 多个数据库集中事务
        /// </summary>
        [Test]
        public void TestGenerateRecordsSingleTran()
        {
            /*
             * Failure: NHibernate.HibernateException : 
             * Multiple simultaneous connections or connections with different connection strings 
             * inside the same transaction are not currently supported
             */
            //using (var ts = new TransactionScope())
            //{
            using (var session = SFHelper.SfCorporate.OpenSession())
            using (var tx1 = session.BeginTransaction())
            {
                var product = new Product { Category = "水果" };
                product.Name = "苹果机构";
                product.Price = 3.1415926M;
                session.Save(product);
                tx1.Commit();
            }

            /************  company main   ***********/
            using (var sessionCompany = SFHelper.SfCompanyMain.OpenSession())
            using (var tx2 = sessionCompany.BeginTransaction())
            {

                var productCompany = new Product { Category = "水果" };
                productCompany.Name = "苹果公司";
                productCompany.Price = 3.1415926M;
                sessionCompany.Save(productCompany);
                tx2.Commit();
            }

            /************ company report  ***********/
            using (var sessionCompanyReport = SFHelper.SfCompanyReport.OpenSession())
            using (var tx3 = sessionCompanyReport.BeginTransaction())
            {

                var productCompanyReport = new Product { Category = "水果" };
                productCompanyReport.Name = "苹果公司报表";
                productCompanyReport.Price = 3.1415926M;
                sessionCompanyReport.Save(productCompanyReport);

                //if (!string.IsNullOrEmpty(productCompanyReport.Name))
                //{
                //    log.Info("report中断退出");
                //    return;
                //}
                tx3.Commit();
            }
            //    ts.Complete();
            //}
            log.Info("完成");
        }

    }
}

/*
 !!!!!!!!!!!!!! 是否生成数据库结构，若是生产环境，一定要注释 !!!!!!!!!!!!!!!
 */
//#define GENERATE_SCHEMA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.Reflection;
using MyFramework.Common.NHibernate.Domain;
using Afx.Common.Constant;
using MyFramework.Common.Constant;
using log4net;
using NHibernate.Tool.hbm2ddl;

namespace MyFramework.Service.Util
{
    /// <summary>
    /// NHibernate Session Factory Helper
    /// </summary>
    public static class SFHelper
    {
        private static ILog log = LogManager.GetLogger(typeof(SFHelper));

        private const string connCorporate = "Database=TestHibernate;Data Source=127.0.0.1;User Id=root;Password=Admin12345";
        private const string connCompany = "Database=TestHibernateMain;Data Source=127.0.0.1;User Id=company;Password=12345";
        private const string connCompanyReport = "Database=TestHibernateReport;Data Source=127.0.0.1;User Id=companyReport;Password=12345";

        private static ISessionFactory _sfCorporate=null;
        private static ISessionFactory _sfCompany = null;
        private static ISessionFactory _sfCompanyReport= null;

        private static object objSync = new object();

        private static ISessionFactory BuildSF(DbType dbType)
        {
            #region session factory
            string conn = null;
            switch (dbType)
            {
                case DbType.CorporateMain:
                    conn = connCorporate; break;

                case DbType.CompanyMain:
                    conn = connCompany; break;

                case DbType.CompanyReport:
                    conn = connCompanyReport; break;
            }
            var configuration = new Configuration();
            //从程序资源中读取
            configuration.Configure(Assembly.GetExecutingAssembly(), "MyFramework.Service.Config.hibernate.cfg.xml");
            //设置连接串
            configuration.SetProperty("connection.connection_string", conn);
            configuration.AddAssembly(typeof(User).Assembly);

#if GENERATE_SCHEMA
            log.Info("生成数据库结构 #开始#");
            new SchemaExport(configuration).Execute(true, true, false);
            log.Info("生成数据库结构 #完成#");
#endif

            return configuration.BuildSessionFactory();
            #endregion
        }

        /// <summary>
        /// 机构SessionFactory
        /// </summary>
        public static ISessionFactory SfCorporate
        {
            get
            {
                #region new
                if (_sfCorporate == null)
                {
                    lock (objSync)
                    {
                        if (_sfCorporate == null)
                        {
                            _sfCorporate = BuildSF(DbType.CorporateMain);
                        }
                    }
                }
                #endregion
                return _sfCorporate;
            }
        }

        /// <summary>
        /// 公司主数据库SessionFactory
        /// </summary>
        public static ISessionFactory SfCompanyMain
        {
            get
            {
                #region new
                if (_sfCompany == null)
                {
                    lock (objSync)
                    {
                        if (_sfCompany == null)
                        {
                            _sfCompany = BuildSF(DbType.CompanyMain);
                        }
                    }
                }
                #endregion
                return _sfCompany;
            }
        }

        /// <summary>
        /// 公司报表SessionFactory
        /// </summary>
        public static ISessionFactory SfCompanyReport
        {
            get
            {
                #region new
                if (_sfCompanyReport == null)
                {
                    lock (objSync)
                    {
                        if (_sfCompanyReport == null)
                        {
                            _sfCompanyReport = BuildSF(DbType.CompanyReport);
                        }
                    }
                }
                #endregion
                return _sfCompanyReport;
            }
        }



    }
}

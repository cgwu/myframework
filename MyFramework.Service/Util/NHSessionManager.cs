using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Constant;
using NHibernate;
using System.Configuration;

namespace MyFramework.Service.Util
{
    /// <summary>
    /// NHibernate Session Manager
    /// </summary>
    public class NHSessionManager : INHSessionManager
    {
        public ISession OpenSession(DbType dbType = DbType.Default)
        {
            return GetSessionFactory(dbType).OpenSession();
        }

        /// <summary>
        /// 打开无状态的Session
        /// 部分操作有性能方面的优势
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public IStatelessSession OpenStatelessSession(DbType dbType = DbType.Default)
        {
            return GetSessionFactory(dbType).OpenStatelessSession();
        }

        private ISessionFactory GetSessionFactory(DbType dbType)
        {
            ISessionFactory sf = null;
            switch (dbType)
            {
                case DbType.CompanyMain:
                    sf = SFHelper.SfCompanyMain;
                    break;
                case DbType.CompanyReport:
                    sf = SFHelper.SfCompanyReport;
                    break;
                case DbType.CorporateMain:
                    sf = SFHelper.SfCorporate;
                    break;
                case DbType.Default:
                    if (ConfigurationManager.AppSettings[SysConstant.DbTypeKey] == "1")
                    {
                        sf = SFHelper.SfCompanyMain;
                    }
                    else
                    {
                        sf = SFHelper.SfCorporate;
                    }
                    break;
            }
            return sf;
        }
    }
}

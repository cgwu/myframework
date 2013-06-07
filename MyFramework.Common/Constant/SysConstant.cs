using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFramework.Common.Constant
{
    public abstract class SysConstant
    {

    }

    /// <summary>
    /// 所有用户级别
    /// </summary>
    public enum UserLevel
    {
        Corporate = 0,
        Company = 1,
        Other = 2
    }

    #region 数据库类型DbType
    public enum DbType
    {
        /// <summary>
        /// 公司主数据库
        /// </summary>
        CompanyMain,
        /// <summary>
        /// 公司报表数据库
        /// </summary>
        CompanyReport,
        /// <summary>
        /// 机构数据库
        /// </summary>
        CorporateMain,
    }
    #endregion


}

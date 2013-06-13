using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Constant;
using NHibernate;

namespace MyFramework.Service.Util
{
    /// <summary>
    /// NHibernate Session Manager
    /// </summary>
    public interface INHSessionManager
    {
        ISession OpenSession(DbType dbType = DbType.Default);

        IStatelessSession OpenStatelessSession(DbType dbType = DbType.Default);
    }
}

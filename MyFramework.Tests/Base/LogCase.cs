using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using NUnit.Framework;
using System.IO;

namespace MyFramework.Tests.Base
{
    [TestFixture]
    public abstract class LogCase
    {
        private const string log4netconfigFile = "log4net.config";
        protected static ILog log = null;

        [TestFixtureSetUp]
        public void setup()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(log4netconfigFile));
            log = LogManager.GetLogger(this.GetType());
            log.Info("log4net日志配置成功!");
        }
    }
}

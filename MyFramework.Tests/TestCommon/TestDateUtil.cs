using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Afx.Common.Message.Base;
using Afx.Common.Message.Util;
using NUnit.Framework;
using log4net;
using System.IO;

namespace MyFramework.Tests.TestCommon
{

    public class TestDateUtil
    {
        private const string log4netconfigFile= "log4net.config";

        private static ILog log = LogManager.GetLogger(typeof(TestDateUtil));


        [SetUp]
        public void setup()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(log4netconfigFile));
            log.Info("setup");
        }
        [Test]
        public void TestDateRange()
        {
            DateRangeReq req = new DateRangeReq();
            req.BeginDate = "2013-05-28";
            req.EndDate = "2013-05-28";
            DateTime[] dt = DateUtil.DateRange(req);
            Console.WriteLine(dt[0].ToStandardDateTime());
            Console.WriteLine(dt[1].ToStandardDateTime());

            Assert.IsNotNullOrEmpty(dt[0].ToStandardDateTime(), dt[0].ToStandardDateTime());
            log.Error("完成");
            //Assert.True(false, "出错啦");
        }
    }
}

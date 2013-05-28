using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Common.Message.Base;
using MyFramework.Common.Message.Util;

namespace MyFramework.Tests.TestCommon
{

    public class TestDateUtil
    {
        public void TestDateRange()
        {
            DateRangeReq req = new DateRangeReq();
            req.BeginDate = "2013-05-28";
            req.EndDate = "2013-05-28";
            DateTime[] dt = DateUtil.DateRange(req);
            Console.WriteLine(dt[0].ToStandardDateTime());
            Console.WriteLine(dt[1].ToStandardDateTime());
        }
    }
}

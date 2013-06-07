using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MyFramework.Tests.TestCommon
{

    public class TestDateTimeRecreate
    {
        [Test]
        public void TestNow()
        {
            DateTime dtNow = DateTime.Now;
            long tickNow = dtNow.ToBinary();
            Console.WriteLine("现在时间:" + dtNow.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine(tickNow);

            DateTime dtRecreate = DateTime.FromBinary(tickNow);
            Console.WriteLine("重建:" + dtRecreate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
    }
}

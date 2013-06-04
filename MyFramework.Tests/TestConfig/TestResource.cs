using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyFramework.Service.Util;

namespace MyFramework.Tests.TestConfig
{
    
    public class TestResource
    {
        [Test]
        public void Test()
        {
            Console.WriteLine("查看程序集的资源：");
            System.Reflection.Assembly thisExe;
            //thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            thisExe = typeof(NHibernateHelper).Assembly;
            string[] resources = thisExe.GetManifestResourceNames();
            string list = "";

            // Build the string of resources.
            foreach (string resource in resources)
                list += resource + "\r\n";

            Console.WriteLine(list);
        }
    }
}

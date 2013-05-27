using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NHibernate.Cfg;
using MyFramework.Common.NHibernate.Domain;
using NHibernate.Tool.hbm2ddl;

namespace MyFramework.Tests
{
    public class GenerateSchema_Fixture
    {
        [Test]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(User).Assembly);

            //new SchemaExport(cfg).Execute(false, true, false, false);
            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}

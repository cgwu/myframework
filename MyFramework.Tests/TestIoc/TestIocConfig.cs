using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyFramework.Service.Ioc;
using MyFramework.Service.Abstract.Account;
using MyFramework.Common.NHibernate.Domain;
using MyFramework.Tests.Base;
using Castle.Core.Logging;
using Castle.Facilities.NHibernateIntegration.Components.Dao;
using NHibernate;
using Castle.Facilities.NHibernateIntegration;

namespace MyFramework.Tests.TestIoc
{
    public class TestIocConfig
    {
        [Test]
        public void TestWindsorConfig()
        {
            var con = Ioc.Container;
            var productRepo = con.Resolve<IProductRepository>("productRepository");
            
            Console.WriteLine(productRepo.GetHashCode());
            for (int i = 0; i < 10; i++)
            {
                productRepo = con.Resolve<IProductRepository>("productRepository");
                Console.WriteLine(productRepo.GetHashCode());
            }

             var product = new Product { Category = "水果" , Name="香蕉transient" };
             productRepo.Add(product);

             con.Dispose();
        }

         [Test]
        public void TestWindsorNHibernate()
        {
            //NHibernateGenericDao dao =null;// new NHibernateGenericDao()

         }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NHibernate;
using NHibernate.Cfg;
using MyFramework.Common.NHibernate.Domain;
using NHibernate.Tool.hbm2ddl;
using MyFramework.Service.Concrete.Account;
using MyFramework.Service.Abstract.Account;
using System.Reflection;
using MyFramework.Service.Util;


namespace MyFramework.Tests.TestDomain
{
    [TestFixture]
    public class ProductRepository_Fixture
    {

        private ISessionFactory _sessionFactory;
        private Configuration _configuration;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            Console.WriteLine("ProductRepository_Fixture TestFixtureSetUp");
            _configuration = new Configuration();
            //_configuration.Configure();
            _configuration.Configure(Assembly.GetAssembly(typeof(NHibernateHelper)), "MyFramework.Service.Config.hibernate.cfg.xml");
            _configuration.AddAssembly(typeof(User).Assembly);
            _sessionFactory = _configuration.BuildSessionFactory();
        }

        [SetUp]
        public void SetupContext()
        {
            Console.WriteLine("ProductRepository_Fixture SetUp");
            new SchemaExport(_configuration).Execute(false, true, false);
        }

        [Test]
        public void Can_add_new_product()
        {
            //Console.WriteLine("当前程序集名1:" + Assembly.GetExecutingAssembly().FullName);

            IProductRepository repository = new ProductRepository();

            for (int i = 0; i < 100; i++)
            {
                var product = new Product { Category = "水果" };
                product.Name = "苹果" + i;
                product.Price = i * 3.14M;
                repository.Add(product);
            }

            for (int i = 0; i < 100; i++)
            {
                var product = new Product { Category = "粮食" };
                product.Name = "大米" + i;
                product.Price = i * 3.14M;
                repository.Add(product);
            }

            using(var session = this._sessionFactory.OpenSession())
            using (var tran = session.BeginTransaction())
            {
                for (int i = 0; i < 100; i++)
                {
                    var u = new User { Name = "cg" + i.ToString(), Password = "000000" + i.ToString() };
                    u.Birthday = DateTime.Now;
                    session.Save(u);
                }
                tran.Commit();
            }

            Console.WriteLine("完成");
        }


        [Test]
        public void Get_by_id()
        {
            Console.WriteLine("ProductRepository_Fixture 开始测试 GetById");
            IProductRepository repository = new ProductRepository();
            Product p = repository.GetById(new Guid("bb318dd5-73be-4543-abe4-007784e1f63b"));
            Console.WriteLine("Id:" + p.Id + "name:" + p.Name + ",category:" + p.Category);
        }


        [Test]
        public void TestGetByCategory()
        {
            Console.WriteLine("ProductRepository_Fixture 开始测试 GetByCategory");
            IProductRepository repository = new ProductRepository();
            var products = repository.GetByCategory("粮食");
            foreach (var p in products)
            {
                Console.WriteLine("Id:" + p.Id + "name:" + p.Name + ",category:" + p.Category);
            }

        }
    }
}

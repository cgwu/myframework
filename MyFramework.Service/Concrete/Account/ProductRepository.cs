using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Service.Abstract.Account;
using NHibernate;
using MyFramework.Service.Util;
using MyFramework.Common.NHibernate.Domain;
using NHibernate.Criterion;
using Castle.Core.Logging;
using Castle.Facilities.NHibernateIntegration;
using MyFramework.Common.Constant;
using System.Diagnostics;

namespace MyFramework.Service.Concrete.Account
{
    public class ProductRepository : IProductRepository
    {
        private ILogger logger = NullLogger.Instance;
        /// <summary>
        /// Windsor注册ProductRepository这个component时会自动注入该属性
        /// </summary>
        public ILogger Logger
        {
            get { return logger; }
            set { logger = value; }
        }

        private ISessionFactory SF;

        public INHSessionManager SessionManager { get; set; }

        public ProductRepository(ISessionFactory SfCompanyMain)
        {
            this.SF = SfCompanyMain;
        }

        private List<Product> GetMockProducts(Product p)
        {
            var list = new List<Product>();
            for (int i = 0; i < 10000; i++)
            {
                list.Add(new Product
                {
                    Name = p.Name + i.ToString(),
                    Category = p.Category + i.ToString(),
                    Price = i
                });
            }
            return list;
        }

        public void Add(Common.NHibernate.Domain.Product product)
        {
            Logger.InfoFormat("正在Add Product{0}", product.Name);

            //法1:成功
            /*using (ISession session = NHibernateHelper.OpenSession())*/
            //法2:成功
            //using (ISession session = SFHelper.SfCompanyMain.OpenSession())   
            //法3:失败
            //using (ISession session = sessionManager.OpenSession("dbMain"))   
            //法4:构造注入，成功
            //using (ISession session = SF.OpenSession())   

            var session = SessionManager.OpenSession();
            //var session = SessionManager.OpenStatelessSession();

            var products = GetMockProducts(product);

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            using (ITransaction transaction = session.BeginTransaction())
            {
                foreach (var p in products)
                {
                    //Logger.Info("正在增加："+p.Name);
                    //session.Insert(p);
                    session.Save(p);
                }
                 

                //session.Save(product);
                transaction.Commit();
            }

            session.Close();

            stopwatch.Stop();
            var time = stopwatch.Elapsed;
            Logger.InfoFormat("完成Add Product{0},Time:{1}", product.Name,time);
        }

        public void Update(Common.NHibernate.Domain.Product product)
        {
            throw new NotImplementedException();
        }

        public void Remove(Common.NHibernate.Domain.Product product)
        {
            throw new NotImplementedException();
        }

        public Common.NHibernate.Domain.Product GetById(Int64 productId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Product>(productId);
        }

        public Common.NHibernate.Domain.Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Common.NHibernate.Domain.Product> GetByCategory(string category)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var products = session
                    .CreateCriteria(typeof(Product))
                    .Add(Restrictions.Eq("Category", category))
                    .List<Product>();
                return products;
            }
        }
    }
}

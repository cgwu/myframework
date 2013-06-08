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


        public void Add(Common.NHibernate.Domain.Product product)
        {
            Logger.InfoFormat("正在Add Product{0}", product.Name);

            //using (ISession session = NHibernateHelper.OpenSession())
            using (ISession session = SFHelper.SfCompanyMain.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }
            Logger.InfoFormat("完成Add Product{0}", product.Name);
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

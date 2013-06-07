using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFramework.Service.Abstract.Account;
using NHibernate;
using MyFramework.Service.Util;
using MyFramework.Common.NHibernate.Domain;
using NHibernate.Criterion;

namespace MyFramework.Service.Concrete.Account
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Common.NHibernate.Domain.Product product)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(product);
                transaction.Commit();
            }
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

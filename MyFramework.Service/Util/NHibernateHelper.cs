﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using MyFramework.Common.NHibernate.Domain;
using System.Reflection;

namespace MyFramework.Service.Util
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    //Console.WriteLine("当前程序集名2:" + Assembly.GetExecutingAssembly().FullName);

                    var configuration = new Configuration();
                    //configuration.Configure();        //从hibernate.cfg.xml文件配置 
                    //configuration.Configure("Config/hibernate.cfg.xml");    //从指定文件
                    configuration.Configure(Assembly.GetExecutingAssembly(), "MyFramework.Service.Config.hibernate.cfg.xml");    //从指定文件
                    configuration.AddAssembly(typeof(User).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}

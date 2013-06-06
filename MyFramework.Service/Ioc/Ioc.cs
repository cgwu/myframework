﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.Core.Resource;

namespace MyFramework.Service.Ioc
{
    public static class Ioc
    {
        private static object objSync = new Object();

        private static WebAppContainer _container = null;

        /// <summary>
        /// 取得Ioc容器对象
        /// </summary>
        public static WebAppContainer Container
        {
            get
            {
                if (_container == null)
                {
                    lock (objSync)
                    {
                        if (_container == null)
                        {
                            _container = new WebAppContainer();
                            _container.Install(
                                Configuration.FromXml(new AssemblyResource("assembly://MyFramework.Service/Config/castle.windsor.config"))
                            );
                        }
                    }
                }
                return _container;
            }
        }
    }
}
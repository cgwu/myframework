using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;

namespace Afx.Common.Ioc
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
                        }
                    }
                }
                return _container;
            }
        }
    }
}

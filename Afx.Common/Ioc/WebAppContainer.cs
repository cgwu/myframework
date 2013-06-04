using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;

namespace Afx.Common.Ioc
{
    public class WebAppContainer : WindsorContainer
    {
        public WebAppContainer()
            : base(new XmlInterpreter())
        {
            //Register(Component.For<DbFactory>().LifestyleSingleton());

            //Register(AllTypes.FromAssembly(Assembly.GetAssembly(typeof(MyService)))
            //.Where(type=>type.Namespace.Contains(MyProject.Services)).WithService.FirstInterface());

            //Register(AllTypes.FromAssembly(Assembly.GetAssembly(typeof(MyDataAccessLayerClass)))
            //.Where(type => type.Namespace.Contains(MyProject.DataAccessLayer.Ioc) && type.IsClass)
            //.Configure(x =>x.LifeStyle.PerWebRequest)
            //.WithService.FirstInterface());
        }
    }
}

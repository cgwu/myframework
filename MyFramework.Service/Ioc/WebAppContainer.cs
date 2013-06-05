using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Castle.Core.Resource;

namespace MyFramework.Service.Ioc
{
    public class WebAppContainer : WindsorContainer
    {
        public WebAppContainer()
        //: base(new XmlInterpreter(new AssemblyResource("assembly://MyFramework.Service/Config/castle.windsor.config")))
        //: base(new XmlInterpreter("Config/castle.windsor.config"))    
        {

        }
    }
}


#region 安装 component 示例
    /*
//http://docs.castleproject.org/Windsor.Installers.ashx         
public class RepositoriesInstaller : IWindsorInstaller
{
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
            container.Register(AllTypes.FromAssemblyNamed("Acme.Crm.Data")
                        .Where(type => type.Name.EndsWith("Repository"))
                        .WithService.DefaultInterface()
                        .Configure(c => c.LifeStyle.PerWebRequest));
    }
}
             
     

    Register(Component.For<DbFactory>().LifestyleSingleton());

    Register(AllTypes.FromAssembly(Assembly.GetAssembly(typeof(MyService)))
    .Where(type=>type.Namespace.Contains(MyProject.Services)).WithService.FirstInterface());

    Register(AllTypes.FromAssembly(Assembly.GetAssembly(typeof(MyDataAccessLayerClass)))
    .Where(type => type.Namespace.Contains(MyProject.DataAccessLayer.Ioc) && type.IsClass)
    .Configure(x =>x.LifeStyle.PerWebRequest)
    .WithService.FirstInterface());
 */

#endregion
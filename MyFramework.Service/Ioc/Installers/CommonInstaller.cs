using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using MyFramework.Service.Util;

namespace MyFramework.Service.Ioc.Installers
{
    /// <summary>
    /// 公用组件注册,如: NHibernate Session Factory.
    /// </summary>
    public class CommonInstaller : IWindsorInstaller
    {

        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            //Session Factory
            container.Register(
                Component.For<NHibernate.ISessionFactory>().Named("SfCorporate").UsingFactoryMethod(_ => SFHelper.SfCorporate),
                Component.For<NHibernate.ISessionFactory>().Named("SfCompanyMain").UsingFactoryMethod(_ => SFHelper.SfCompanyMain),
                Component.For<NHibernate.ISessionFactory>().Named("SfCompanyReport").UsingFactoryMethod(_ => SFHelper.SfCompanyReport)
                );

            //Session Manager
            container.Register(
               Component.For<INHSessionManager>().ImplementedBy<NHSessionManager>().Named("NHSessionManager.default"));
        }
    }
}

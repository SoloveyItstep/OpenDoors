using Autofac;
using Autofac.Integration.Mvc;
using OpenDoors.EntityDb;
using OpenDoors.EntityDb.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenDoors.Inject
{
    public class AutofacConf
    {
        public static void ConfigureContainer()
        {
            ContainerBuilder builder = new ContainerBuilder();
            RegisterTypes(ref builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterTypes(ref ContainerBuilder builder)
        {
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.Register(c => new ContextDb("LocalDb")).As<IContextDb>();
            //    //.WithParameter("ConnectionName","LocalDb");
            //builder.RegisterType<ContextDb>().As<IContextDb>()
            //    .WithParameter("ConnectionName", "LocalDb");
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>()
                .WithParameter("context",new ContextDb("LocalDb"));
        }
    }
}
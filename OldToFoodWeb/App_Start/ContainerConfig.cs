using Autofac;
using Autofac.Integration.Mvc;
using ClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OldToFoodWeb
    //method envoke
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryRestaurantData>()
                .As<IRestaurantData>()
                .SingleInstance();
            var container = builder.Build();
            AutofacDependencyResolver.SetAutofacDependencyResolverAccessor(new AutofacDependencyResolver(container));

        }
    }
}
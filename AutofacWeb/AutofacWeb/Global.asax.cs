using Autofac;
using Autofac.Integration.Mvc;
using AutofacWeb.Implementation;
using AutofacWeb.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AutofacWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // using autofac
            var builder = new ContainerBuilder();
            builder.RegisterType<Restaurant>().As<IRestaurant>();
            // singleton pattern
            builder.RegisterType<Vechile>().As<IVechile>().SingleInstance();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

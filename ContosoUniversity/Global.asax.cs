using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity.Infrastructure.Interception;

using ContosoUniversity.DAL;
using AutoMapper;
using ContosoUniversity.App_Start;

namespace ContosoUniversity
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize( c => c.AddProfile<MappingProfile>());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());

        }
    }
}

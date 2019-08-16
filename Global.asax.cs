using DP_60321_TROSHKO.Models.Entities;
using DP_60321_TROSHKO.Models.Interfaces;
using DP_60321_TROSHKO.Models.Repositories;
using Ninject;
using Ninject.Web.Common.WebHost;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DP_60321_TROSHKO
{
    public class MvcApplication : NinjectHttpApplication //System.Web.HttpApplication
    {
        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

            //Внедрение зависимостей

            //NinjectModule registrations = new NinjectRegistrations();
            //var kernel = new StandardKernel(registrations);
            //DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));


               protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IRepository<AdCategories>>().To<RepositoryCategory>();
            kernel.Bind<IRepository<AdPosts>>().To<RepositoryPost>();
            kernel.Bind<IRepository<Offers>>().To<RepositoryOffer>();
            kernel.Bind<IRepository<Comments>>().To<RepositoryComment>();
            return kernel;
        }

      }

    }


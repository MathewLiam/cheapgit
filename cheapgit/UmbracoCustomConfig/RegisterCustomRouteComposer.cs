using cheapgit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace cheapgit.UmbracoCustomConfig
{
    public class RegisterCustomRouteComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<BasketController>(Lifetime.Request);
            composition.Components()
             .Append<RegisterCustomRouteComponent>();
        }
    }

    public class RegisterCustomRouteComponent : IComponent
    {
        public void Initialize()
        {
            RouteTable.Routes.MapRoute(
                "CartPage",
                "cart",
                new { controller = "Basket", action = "Index" }
                );
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}
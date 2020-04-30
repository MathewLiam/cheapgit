namespace cheapgit.UmbracoCustomConfig
{
    using cheapgit.Controllers;
    using System;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Umbraco.Core;
    using Umbraco.Core.Composing;

    /// <summary>
    /// Defines the <see cref="RegisterCustomRouteComposer" />.
    /// </summary>
    public class RegisterCustomRouteComposer : IUserComposer
    {
        /// <summary>
        /// The Compose.
        /// </summary>
        /// <param name="composition">The composition<see cref="Composition"/>.</param>
        public void Compose(Composition composition)
        {
            composition.Register<BasketController>(Lifetime.Request);
            composition.Components()
             .Append<RegisterCustomRouteComponent>();
        }
    }

    /// <summary>
    /// Defines the <see cref="RegisterCustomRouteComponent" />.
    /// </summary>
    public class RegisterCustomRouteComponent : IComponent
    {
        /// <summary>
        /// The Initialize.
        /// </summary>
        public void Initialize()
        {
            RouteTable.Routes.MapRoute(
                "CartPage",
                "cart",
                new { controller = "Basket", action = "Index" }
                );
        }

        /// <summary>
        /// The Terminate.
        /// </summary>
        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace cheapgit.Controllers
{
    public class BasketController : Controller
    {
        private readonly UmbracoContext umbracoContext;

        public BasketController()
        {
            umbracoContext = DependencyResolver.Current.GetService<IUmbracoContextFactory>().EnsureUmbracoContext().UmbracoContext;
        }
        // GET: Basket
        public ActionResult Index()
        {
            // Gets the home node
            var context = umbracoContext.Content.GetByRoute("/");



            return View(context);
        }
    }
}
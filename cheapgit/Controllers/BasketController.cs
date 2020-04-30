namespace cheapgit.Controllers
{
    using System.Web.Mvc;
    using Umbraco.Web;

    /// <summary>
    /// Defines the <see cref="BasketController" />.
    /// </summary>
    public class BasketController : Controller
    {
        /// <summary>
        /// Defines the umbracoContext.
        /// </summary>
        private readonly UmbracoContext umbracoContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="BasketController"/> class.
        /// Assigns value to the umbracoContent property.
        /// </summary>
        public BasketController()
        {
            umbracoContext = DependencyResolver.Current.GetService<IUmbracoContextFactory>().EnsureUmbracoContext().UmbracoContext;
        }

        // GET: Basket
        /// <summary>
        /// Gets the Index vew for the Basket.
        /// </summary>
        /// <returns>The Index view for the Basket <see cref="ActionResult"/>.</returns>
        public ActionResult Index()
        {
            // Gets the home node
            var context = umbracoContext.Content.GetByRoute("/");
            return View(context);
        }
    }
}

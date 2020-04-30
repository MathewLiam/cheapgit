namespace cheapgit.Controllers
{
    using cheapgit.DAL.Models;
    using cheapgit.DAL.Workers;
    using cheapgit.DAL.Workers.Interfaces;
    using cheapgit.ViewModels.pages;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Umbraco.Web.Models;

    /// <summary>
    /// Defines the <see cref="ProductsController" />.
    /// </summary>
    public class ProductsController : Umbraco.Web.Mvc.RenderMvcController
    {
        /// <summary>
        /// Defines the _oracleApiWorker.
        /// </summary>
        private IApiWorker _oracleApiWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsController"/> class.
        /// Assignes value to the _oracleApiWorker
        /// </summary>
        public ProductsController()
        {
            _oracleApiWorker = new OracleApiWorker(ConfigurationSettings.AppSettings.Get("OcelotAPIGateway"));
        }

        /// <summary>
        /// Returns the view for product list page after retrieving the relevant products
        /// </summary>
        /// <param name="content">The content<see cref="ContentModel"/>.</param>
        /// <returns>The product list page view.</returns>
        public async Task<ActionResult> Index(ContentModel content)
        {
            var categories = content.Content.GetProperty("categories").GetValue();

            List<Product> productslist = new List<Product>();

            foreach (var category in (string[])categories)
            {
                var categoryProducts = await _oracleApiWorker.GetProductsByCategory(category);
                productslist.AddRange(categoryProducts);
            }

            var model = new ProductListViewModel(content.Content)
            {
                products = productslist
            };

            return CurrentTemplate(model);
        }
    }
}

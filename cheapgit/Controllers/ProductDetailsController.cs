namespace cheapgit.Controllers
{
    using cheapgit.DAL.Workers;
    using cheapgit.DAL.Workers.Interfaces;
    using cheapgit.ViewModels.pages;
    using System.Configuration;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Umbraco.Web.Models;

    /// <summary>
    /// Defines the <see cref="ProductDetailsController" />.
    /// </summary>
    public class ProductDetailsController : Umbraco.Web.Mvc.RenderMvcController
    {
        /// <summary>
        /// Defines the _oracleApiWorker.
        /// </summary>
        private readonly IApiWorker _oracleApiWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailsController"/> class.
        /// </summary>
        public ProductDetailsController()
        {
            _oracleApiWorker = new OracleApiWorker(ConfigurationSettings.AppSettings.Get("OcelotAPIGateway"));
        }

        /// <summary>
        /// Returns the product details view
        /// </summary>
        /// <param name="content">The content<see cref="ContentModel"/>.</param>
        /// <param name="id">The id of the product<see cref="string"/>.</param>
        /// <returns>The product details page.</returns>
        public async Task<ActionResult> Index(ContentModel content, string id)
        {
            var model = new ProductDetailsViewModel(content.Content)
            {
                product = await _oracleApiWorker.GetProductById(id)
            };

            return CurrentTemplate(model);
        }
    }
}

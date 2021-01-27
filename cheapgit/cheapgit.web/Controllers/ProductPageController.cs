namespace cheapgit.web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Piranha;
    using Piranha.AspNetCore.Services;
    using System;
    using System.Threading.Tasks;
    using Models.Posts;

    /// <summary>
    /// Controller for product pages.
    /// </summary>
    public class ProductPageController : Controller
    {
        private readonly IApi _api;
        private readonly IModelLoader _loader;

        /// <summary>
        /// Initializes a new instance of the ProductPageController<see cref="ProductPageController"/>.
        /// </summary>
        /// <param name="api">The current api</param>
        public ProductPageController(IApi api, IModelLoader loader)
        {
            _api = api;
            _loader = loader;
        }

        /// <summary>
        /// Gets the view for the product page.
        /// </summary>
        /// <param name="id"><see cref="Guid"/>Id of the page requested.</param>
        /// <param name="draft"></param>
        /// <returns>A ProductPage view.</returns>
        public async Task<IActionResult> Index(Guid id, bool draft = false, string? searchTerm=null)
        {
            try
            {
                var model = await _loader.GetPostAsync<ProductPage>(id, HttpContext.User, draft);

                return View("~/Views/Cms/ProductsPage.cshtml", model);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
        }
    }
}
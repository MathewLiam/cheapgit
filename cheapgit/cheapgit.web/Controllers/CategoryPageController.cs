namespace cheapgit.web.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Piranha;
    using Piranha.AspNetCore.Services;
    using Piranha.Models;

    /// <summary>
    /// Class for category page functionality.
    /// </summary>
    public class CategoryPageController : Controller
    {
        /// <summary>
        /// The current PiranhaCMS API context.
        /// </summary>
        private readonly IApi _api;

        /// <summary>
        /// Loads the specific models tailored for each users access.
        /// </summary>
        private readonly IModelLoader _loader;

        /// <summary>
        /// <see cref="CategoryPageController"/>Initializes a new instance of the CategoryPageController class.
        /// </summary>
        /// <param name="api">The current api</param>
        public CategoryPageController(IApi api, IModelLoader loader)
        {
            _api = api;
            _loader = loader;
        }

        /// <summary>
        /// Gets the blog archive with the given id.
        /// </summary>
        /// <param name="id">The unique page id</param>
        /// <param name="year">The optional year</param>
        /// <param name="month">The optional month</param>
        /// <param name="page">The optional page</param>
        /// <param name="category">The optional category</param>
        /// <param name="tag">The optional tag</param>
        /// <param name="draft">If a draft is requested</param>
        public async Task<IActionResult> Index(Guid id, int? year = null, int? month = null, int? page = null,
            Guid? category = null, Guid? tag = null, bool draft = false)
        {
            try
            {
                var model = await _loader.GetPageAsync<Models.Pages.CategoryArchive>(id, HttpContext.User, draft);
                model.Archive = await _api.Archives.GetByIdAsync<PostInfo>(id, page, category, tag, year, month);

                return View("~/Views/Cms/CategoryPage.cshtml", model);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
        }
    }
}
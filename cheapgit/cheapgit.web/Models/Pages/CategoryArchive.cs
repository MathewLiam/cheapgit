namespace cheapgit.web.Models.Pages
{
    using cheapgit.web.Models.Posts;
    using Piranha.AttributeBuilder;
    using Piranha.Models;

    /// <summary>
    /// Defines the category page type.
    /// </summary>
    [PageType(Title = "Category Page", IsArchive =true)]
    [PageTypeArchiveItem(typeof(ProductPage))]
    [PageTypeRoute(Title = "Category Page Route",Route = "/CategoryPage/Index")]
    public class CategoryArchive : Page<CategoryArchive>
    {
        /// <summary>
        /// The currently loaded post archive.
        /// </summary>
        public PostArchive<PostInfo> Archive { get; set; }
    }
}

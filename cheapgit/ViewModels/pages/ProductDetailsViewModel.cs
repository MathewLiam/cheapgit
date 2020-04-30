namespace cheapgit.ViewModels.pages
{
    using cheapgit.DAL.Models;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Web.Models;

    /// <summary>
    /// Defines the <see cref="ProductDetailsViewModel" />.
    /// </summary>
    public class ProductDetailsViewModel : ContentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetailsViewModel"/> class.
        /// </summary>
        /// <param name="content">The content<see cref="IPublishedContent"/>.</param>
        public ProductDetailsViewModel(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public Product product { get; set; }
    }
}

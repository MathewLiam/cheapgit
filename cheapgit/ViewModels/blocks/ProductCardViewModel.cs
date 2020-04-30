namespace cheapgit.ViewModels.blocks
{
    using cheapgit.DAL.Models;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Web.Models;

    /// <summary>
    /// Defines the <see cref="ProductCardViewModel" />.
    /// </summary>
    public class ProductCardViewModel : ContentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCardViewModel"/> class.
        /// </summary>
        /// <param name="content">The content<see cref="IPublishedContent"/>.</param>
        public ProductCardViewModel(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public Product product { get; set; }
    }
}

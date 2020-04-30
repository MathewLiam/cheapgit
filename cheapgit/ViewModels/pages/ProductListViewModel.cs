namespace cheapgit.ViewModels.pages
{
    using cheapgit.DAL.Models;
    using System.Collections.Generic;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Web.Models;

    /// <summary>
    /// Defines the <see cref="ProductListViewModel" />.
    /// </summary>
    public class ProductListViewModel : ContentModel
    {
        // Standard Model Pass Through
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListViewModel"/> class.
        /// </summary>
        /// <param name="content">The content<see cref="IPublishedContent"/>.</param>
        public ProductListViewModel(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Gets or sets the products list.
        /// </summary>
        public IEnumerable<Product> products { get; set; }
    }
}

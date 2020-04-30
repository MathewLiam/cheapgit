namespace cheapgit.Controllers
{
    using cheapgit.DAL.Models;
    using cheapgit.ViewModels.blocks;
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Web.Mvc;

    /// <summary>
    /// Defines the <see cref="ProductReviewController" />.
    /// </summary>
    public class ProductReviewController : SurfaceController
    {
        /// <summary>
        /// Returns the partial view for product rating card
        /// </summary>
        /// <param name="content">The content<see cref="IPublishedContent"/>.</param>
        /// <param name="productReviews">The list of product reviews for a product<see cref="IEnumerable{ProductReview}"/>.</param>
        /// <returns>The product rating partial view.</returns>
        public ActionResult GetProductRating(IPublishedContent content, IEnumerable<ProductReview> productReviews)
        {
            ProductRatingCardViewModel model = new ProductRatingCardViewModel(content)
            {
                reviews = productReviews
            };

            return PartialView("_ProductRatingCard", model);
        }
    }
}

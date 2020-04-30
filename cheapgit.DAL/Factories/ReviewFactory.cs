namespace cheapgit.DAL.Factories
{
    using cheapgit.DAL.Factories.Interfaces;
    using cheapgit.DAL.Models;
    using cheapgit.DAL.Models.OracleServiceModels;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="ReviewFactory" />.
    /// </summary>
    public class ReviewFactory : IReviewFactory
    {
        /// <summary>
        /// The GenerateReview.
        /// </summary>
        /// <param name="review">The review<see cref="OracleProductReview"/>.</param>
        /// <returns>The <see cref="ProductReview"/>.</returns>
        public ProductReview GenerateReview(OracleProductReview review)
        {
            return new ProductReview
            {
                id = review.id,
                productid = review.productid,
                dateAdded = review.dateAdded,
                commentTitle = review.commentTitle,
                commentBody = review.commentBody,
                flaggedInappropriate = review.flaggedInappropriate,
                rating = review.rating
            };
        }

        /// <summary>
        /// The GenerateReview.
        /// </summary>
        /// <param name="review">The review<see cref="ProductReview"/>.</param>
        /// <returns>The <see cref="OracleProductReview"/>.</returns>
        public OracleProductReview GenerateReview(ProductReview review)
        {
            return new OracleProductReview
            {
                id = review.id,
                productid = review.productid,
                dateAdded = review.dateAdded,
                commentTitle = review.commentTitle,
                commentBody = review.commentBody,
                flaggedInappropriate = review.flaggedInappropriate,
                rating = review.rating
            };
        }

        /// <summary>
        /// The GenerateReviews.
        /// </summary>
        /// <param name="reviews">The reviews<see cref="IEnumerable{OracleProductReview}"/>.</param>
        /// <returns>The <see cref="IEnumerable{ProductReview}"/>.</returns>
        public IEnumerable<ProductReview> GenerateReviews(IEnumerable<OracleProductReview> reviews)
        {
            List<ProductReview> productReviews = new List<ProductReview>();

            foreach (var review in reviews)
            {
                productReviews.Add(this.GenerateReview(review));
            }

            return productReviews;
        }
    }
}

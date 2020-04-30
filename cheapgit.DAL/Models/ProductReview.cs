namespace cheapgit.DAL.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="ProductReview" />.
    /// </summary>
    public class ProductReview
    {
        /// <summary>
        /// Gets or sets the review id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        public string productid { get; set; }

        /// <summary>
        /// Gets or sets the dateAdded.
        /// </summary>
        public DateTime dateAdded { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public float rating { get; set; }

        /// <summary>
        /// Gets or sets the commentTitle.
        /// </summary>
        public string commentTitle { get; set; }

        /// <summary>
        /// Gets or sets the commentBody.
        /// </summary>
        public string commentBody { get; set; }

        /// <summary>
        /// Gets or sets the flaggedInappropriate.
        /// </summary>
        public int flaggedInappropriate { get; set; }
    }
}

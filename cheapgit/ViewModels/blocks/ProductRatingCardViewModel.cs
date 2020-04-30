namespace cheapgit.ViewModels.blocks
{
    using cheapgit.DAL.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Umbraco.Core.Models.PublishedContent;
    using Umbraco.Web.Models;

    /// <summary>
    /// Defines the <see cref="ProductRatingCardViewModel" />.
    /// </summary>
    public class ProductRatingCardViewModel : ContentModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRatingCardViewModel"/> class.
        /// </summary>
        /// <param name="content">The content<see cref="IPublishedContent"/>.</param>
        public ProductRatingCardViewModel(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Gets the averageScore rating.
        /// </summary>
        public float averageScore
        {
            get
            {
                return reviews.Sum(m => m.rating) / reviews.Count();
            }
        }

        /// <summary>
        /// Gets the amount that scored a rating of 5.
        /// </summary>
        public int amt5Score
        {
            get
            {
                return reviews.Where(m => m.rating == 5).Count();
            }
        }

        /// <summary>
        /// Gets the amount that scored a rating of 4.
        /// </summary>
        public int amt4Score
        {
            get
            {
                return reviews.Where(m => m.rating >= 4 && m.rating < 5).Count();

            }
        }

        /// <summary>
        /// Gets the amount that scored a rating of 3.
        /// </summary>
        public int amt3Score
        {
            get
            {
                return reviews.Where(m => m.rating >= 3 && m.rating < 4).Count();
            }
        }

        /// <summary>
        /// Gets the amount that scored a rating of 2.
        /// </summary>
        public int amt2Score
        {
            get
            {
                return reviews.Where(m => m.rating >= 2 && m.rating < 3).Count();
            }
        }

        /// <summary>
        /// Gets the amount that scored a rating of 1.
        /// </summary>
        public int amt1Score
        {
            get
            {
                return reviews.Where(m => m.rating >= 1 && m.rating < 2).Count();
            }
        }

        /// <summary>
        /// Gets the total amount of reviews
        /// </summary>
        public int totalReviews
        {
            get
            {
                return reviews.Count();
            }
        }

        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        [Required]
        public IEnumerable<ProductReview> reviews { get; set; }
    }
}

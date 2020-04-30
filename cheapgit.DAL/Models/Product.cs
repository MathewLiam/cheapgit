namespace cheapgit.DAL.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Product" />.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        public string brand { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// Gets or sets the colours.
        /// </summary>
        public string colours { get; set; }

        /// <summary>
        /// Gets or sets the dateAdded.
        /// </summary>
        public DateTime? dateAdded { get; set; }

        /// <summary>
        /// Gets or sets the dateUpdated.
        /// </summary>
        public DateTime? dateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the dimensions.
        /// </summary>
        public string dimensions { get; set; }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        public string keys { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public string tags { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>
        public string manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public float price { get; set; }

        /// <summary>
        /// Gets or sets the retailPrice.
        /// </summary>
        public float retailPrice { get; set; }

        /// <summary>
        /// Gets or sets the autoExpire.
        /// </summary>
        public int autoExpire { get; set; }

        /// <summary>
        /// Gets or sets the autoExpireDate.
        /// </summary>
        public DateTime? autoExpireDate { get; set; }

        /// <summary>
        /// Gets or sets the featureBullets.
        /// </summary>
        public string featureBullets { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        public IEnumerable<string> images { get; set; }

        /// <summary>
        /// Gets or sets the reviews.
        /// </summary>
        public IEnumerable<ProductReview> reviews { get; set; }
    }
}

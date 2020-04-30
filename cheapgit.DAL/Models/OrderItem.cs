namespace cheapgit.DAL.Models
{
    /// <summary>
    /// Defines the <see cref="OrderItem" />.
    /// </summary>
    internal class OrderItem
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the orderid.
        /// </summary>
        public string orderid { get; set; }

        /// <summary>
        /// Gets or sets the productid.
        /// </summary>
        public int productid { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int quantity { get; set; }

        /// <summary>
        /// Gets or sets the cumulativeValue.
        /// </summary>
        public float cumulativeValue { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public virtual Order order { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public virtual Product product { get; set; }
    }
}

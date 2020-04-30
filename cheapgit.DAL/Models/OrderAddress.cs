namespace cheapgit.DAL.Models
{
    /// <summary>
    /// Defines the <see cref="OrderAddress" />.
    /// </summary>
    internal class OrderAddress
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the addressln1.
        /// </summary>
        public string addressln1 { get; set; }

        /// <summary>
        /// Gets or sets the addressln2.
        /// </summary>
        public string addressln2 { get; set; }

        /// <summary>
        /// Gets or sets the addressln3.
        /// </summary>
        public string addressln3 { get; set; }

        /// <summary>
        /// Gets or sets the town_city.
        /// </summary>
        public string town_city { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public string county { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        public string postcode { get; set; }

        /// <summary>
        /// Gets or sets the orderid.
        /// </summary>
        public string orderid { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public virtual Order order { get; set; }
    }
}

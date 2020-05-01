namespace cheapgit.DAL.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="Order" />.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the customerid.
        /// </summary>
        public string customerid { get; set; }

        /// <summary>
        /// Gets or sets the orderdate.
        /// </summary>
        public DateTime orderdate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual Customer customer { get; set; }
    }
}

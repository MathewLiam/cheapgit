namespace cheapgit.DAL.Models
{
    /// <summary>
    /// Defines the <see cref="Customer" />.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the forename.
        /// </summary>
        public string forename { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string surname { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string email { get; set; }
    }
}

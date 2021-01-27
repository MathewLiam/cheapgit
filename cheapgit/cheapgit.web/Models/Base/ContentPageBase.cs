namespace cheapgit.web.Models.Base
{
    using Piranha.Extend;
    using Piranha.Extend.Fields;

    /// <summary>
    /// Defines the base class for all generic content pages.
    /// </summary>
    public class ContentPageBase
    {
        /// <summary>
        /// Gets or sets the IsShowInFooter value.
        /// </summary>
        [Field(Title = "Show in footer")]
        [FieldDescription(Text = "Set to true to add a link for this page in the footer.")]
        public CheckBoxField IsShowInFooter { get; set; }
    }
}

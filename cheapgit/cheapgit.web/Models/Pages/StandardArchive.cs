namespace cheapgit.web.Models.Pages
{
    using Piranha.AttributeBuilder;
    using Piranha.Models;
    using cheapgit.web.Models.Base;

    [PageType(Title = "Standard archive", IsArchive = true)]
    public class StandardArchive : Page<StandardArchive>
    {
        /// <summary>
        /// The currently loaded post archive.
        /// </summary>
        public PostArchive<PostInfo> Archive { get; set; }
    }
}
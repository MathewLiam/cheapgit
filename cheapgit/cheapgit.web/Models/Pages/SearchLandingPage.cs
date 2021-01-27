namespace cheapgit.web.Models.Pages
{
    using Piranha.AttributeBuilder;
    using Piranha.Models;

    /// <summary>
    /// Defines the search landing page type.
    /// </summary>
    [PageType(Title = "Search Landing Page")]
    [PageTypeRoute(Route = "/Search")]
    public class SearchLandingPage : Page<SearchLandingPage>
    {
    }
}

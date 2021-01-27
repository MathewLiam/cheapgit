namespace cheapgit.web.Models.Posts
{
    using Piranha.AttributeBuilder;
    using Piranha.Extend;
    using Piranha.Extend.Fields;
    using Piranha.Models;

    [PostType(Title = "Product page")]
    [PostTypeRoute(Title = "Product Page Route",Route = "/ProductPage/Index")]
    public class ProductPage : Post<ProductPage>
    {

        public class Settings
        {
            [Field]
            public TextField SearchTerm { get; set; }

            [Field]
            public NumberField CategoryId { get; set; }
        }

        [Region]
        public Settings PageSettings { get; set; }
    }
}

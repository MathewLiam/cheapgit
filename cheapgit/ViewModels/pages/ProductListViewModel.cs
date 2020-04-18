using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using cheapgit.DAL.Models;

namespace cheapgit.ViewModels.pages
{
    public class ProductListViewModel : ContentModel
    {
        // Standard Model Pass Through
        public ProductListViewModel(IPublishedContent content) : base(content) { }

        public IEnumerable<Product> products { get; set; }

    }
}
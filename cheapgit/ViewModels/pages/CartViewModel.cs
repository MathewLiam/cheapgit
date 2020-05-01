using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using cheapgit.DAL.Models;

namespace cheapgit.ViewModels.pages
{
    public class CartViewModel : ContentModel
    {
        public CartViewModel(IPublishedContent content) 
            : base(content)
        {

        }

        public IEnumerable<OrderItem> Items { get; set; }

        public float TotalValue
        {
            get
            {
                return TotalValue;
            }
            private set
            {
                TotalValue = (float) Items.Sum(m => m.product.price * (float)m.quantity);
            }
        }
    }
}
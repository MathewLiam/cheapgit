using cheapgit.DAL.Models;
using cheapgit.ViewModels.blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace cheapgit.Controllers
{
    public class ProductReviewController : SurfaceController
    {
        public ActionResult GetProductRating(IPublishedContent content, IEnumerable<ProductReview> productReviews)
        {
            ProductRatingCardViewModel model = new ProductRatingCardViewModel(content)
            {
                reviews = productReviews
            };
            
            return PartialView("_ProductRatingCard", model);
        }
    }
}
using cheapgit.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;

namespace cheapgit.ViewModels.blocks
{
    public class ProductRatingCardViewModel : ContentModel
    {
        public ProductRatingCardViewModel(IPublishedContent content)  : base(content)
        {
        }
        public float averageScore {
            get
            {
                return reviews.Sum(m => m.rating) / reviews.Count();
            }
        }
        public int amt5Score {
            get 
            {
                return reviews.Where(m => m.rating == 5).Count();
            }
        }
        public int amt4Score { 
            get 
            {
                return reviews.Where(m => m.rating >= 4 && m.rating < 5).Count();

            }
        }
        public int amt3Score { 
            get
            {
                return reviews.Where(m => m.rating >= 3 && m.rating < 4).Count();
            }
        }
        public int amt2Score { 
            get
            {
                return reviews.Where(m => m.rating >= 2 && m.rating < 3).Count();
            }
        }
        public int amt1Score { 
            get 
            {
                return reviews.Where(m => m.rating >= 1 && m.rating < 2).Count();
            } 
        }

        [Required]
        public IEnumerable<ProductReview> reviews { get; set; }
    }
}
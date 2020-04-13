using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Models.OracleServiceModels;
using cheapgit.DAL.Models;
namespace cheapgit.DAL.Factories.Interfaces
{
    public interface IReviewFactory
    {
        IEnumerable<ProductReview> GenerateReviews(IEnumerable<OracleProductReview> reviews);
        ProductReview GenerateReview(OracleProductReview review);
        OracleProductReview GenerateReview(ProductReview review);


    }
}

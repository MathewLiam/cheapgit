﻿using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Factories.Interfaces;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;

namespace cheapgit.DAL.Factories
{
    public class ReviewFactory : IReviewFactory
    {
        public ProductReview GenerateReview(OracleProductReview review)
        {
            return new ProductReview
            {
                id = review.id,
                productid = review.productid,
                dateAdded = review.dateAdded,
                durability = review.durability,
                product_value = review.product_value,
                overall = review.overall
            };
        }

        public OracleProductReview GenerateReview(ProductReview review)
        {
            return new OracleProductReview
            {
                id = review.id,
                productid = review.productid,
                dateAdded = review.dateAdded,
                durability = review.durability,
                product_value = review.product_value,
                overall = review.overall
            };
        }

        public IEnumerable<ProductReview> GenerateReviews(IEnumerable<OracleProductReview> reviews)
        {
            List<ProductReview> productReviews = new List<ProductReview>();

            foreach (var review in reviews)
            {
                productReviews.Add(this.GenerateReview(review));
            }

            return productReviews;
        }
    }
}

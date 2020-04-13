using System;
using System.Collections.Generic;
using System.Text;
using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;
using cheapgit.DAL.Factories;
using cheapgit.DAL.Factories.Interfaces;
using NUnit.Framework;

namespace cheapgit.test.DAL.Factories
{
    class ReviewFactorySpec
    {
        IReviewFactory reviewfactory = new ReviewFactory();
        [Test]
        public void CanGenerateReviewFromOracleReview()
        {
            var oraclereview = new OracleProductReview
            {
                id = "REVIEWID",
                productid = "PRODUCTID",
                dateAdded =  new System.DateTime(),
                durability = 4.5F,
                product_value = 3.6F,
                overall = 3.9F
            };

            var productreview = this.reviewfactory.GenerateReview(oraclereview);

            Assert.True(productreview is ProductReview);

            Assert.AreEqual("REVIEWID", productreview.id);
        }
        
        [Test]
        public void CanGenerateListReviewFromOracleReviews()
        {
            var listoraclereview = new List<OracleProductReview>
            {
                new OracleProductReview
                {
                    id = "REVIEWID",
                    productid = "PRODUCTID",
                    dateAdded =  new System.DateTime(),
                    durability = 4.5F,
                    product_value = 3.6F,
                    overall = 3.9F
                },
                new OracleProductReview
                {
                    id = "REVIEWID2",
                    productid = "PRODUCTID2",
                    dateAdded =  new System.DateTime(),
                    durability = 5F,
                    product_value = 3.9F,
                    overall = 3.3F
                }
            };

            var listproductreviews = (List<ProductReview>)this.reviewfactory.GenerateReviews(listoraclereview);

            Assert.True(listproductreviews is List<ProductReview>);

            Assert.AreEqual("REVIEWID", listproductreviews[0].id);
            Assert.AreEqual("REVIEWID2", listproductreviews[1].id);

        }
    }
}

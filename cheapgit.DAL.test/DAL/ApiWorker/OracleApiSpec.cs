using NUnit.Framework;
using cheapgit.DAL.Models;
using cheapgit.DAL.Workers;
using cheapgit.DAL.Workers.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace cheapgit.test.DAL.ApiWorker
{
    public class OracleApiSpec
    {
        OracleApiWorker apiworker = new OracleApiWorker("http://localhost:5000");

        [Test]
        public void CanFetchListOfProducts()
        {
            var response = apiworker.GetProducts();

            Assert.True(response is Task<IEnumerable<Product>>);
        }

        [Test]
        public void CanFetchListOfProductsByCategory()
        {
            var response = apiworker.GetProductsByCategory("laptop");
            List<Product> products = (List<Product>)response.Result;

            Assert.True(products is IEnumerable<Product>);
        }

        [Test]
        public void CanFetchProductById()
        {
            var response = apiworker.GetProductById("PRODUCT1235");
            Assert.True(response is Task<Product>);
            var product = response.Result;
        }

        [Test]
        public void CanFetchProductReviews()
        {
            var response = apiworker.GetProductReviews("PRODUCT1235");

            Assert.True(response is Task<IEnumerable<ProductReview>>);
        }

        [Test]
        public void CanFetchProductReviewById()
        {
            var response = apiworker.GetProductReview("PRODUCT1235", "REVIEW1");

            Assert.True(response is Task<ProductReview>);
        }

        [Test]
        public void CanFetchProductImage()
        {
            var response = apiworker.GetProductImages("PRODUCT1237");

            Assert.True(response.Result is IEnumerable<String>);
        }
    }
}
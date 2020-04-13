using NUnit.Framework;
using cheapgit.DAL.Models;
using cheapgit.DAL.Workers;
using cheapgit.DAL.Workers.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace cheapgit.test.DAL.ApiWorker
{
    public class OracleApiSpec
    {
        OracleApiWorker apiworker = new OracleApiWorker("http://localhost:5000");

        [Test]
        public void CanFetchListOfProducts()
        {
            var response = apiworker.GetProducts();
            List<Product> products = (List<Product>) response.Result;

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
        public void CanFetchProductComments()
        {
            var response = apiworker.GetProductComments("PRODUCT1235");
            
            Assert.True(response.Result is IEnumerable<ProductComment>);
        }

        [Test]
        public void CanFetchProductCommentById()
        {
            var response = apiworker.GetProductComment("PRODUCT1235", "COMMENT1");
            Assert.True(response is Task<ProductComment>);
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

    }
}
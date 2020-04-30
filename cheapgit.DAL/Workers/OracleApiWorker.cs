using cheapgit.DAL.Models;
using cheapgit.DAL.Models.OracleServiceModels;
using cheapgit.DAL.Workers.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Resources;
using System.Net.Http.Headers;
using cheapgit.DAL.Factories.Interfaces;
using cheapgit.DAL.Factories;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace cheapgit.DAL.Workers
{
    public class OracleApiWorker : IApiWorker
    {
        // Base uri path for products
        private string ProductsBaseUri { get { return "/products"; } }

        // Base uri for orders
        private string OrdersBaseUri { get { return "/orders"; } }

        private string CategoriesBaseUri { get { return "/categories"; } }

        private HttpClient client;
        private ResourceManager resourceManager;
        private IProductFactory productFactory;
        private IReviewFactory reviewFactory;

        public OracleApiWorker(string baseUri)
        {

            this.client = new HttpClient();
            this.client.BaseAddress = new Uri(baseUri);
            this.client.DefaultRequestHeaders.Accept.Clear();
            this.client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("Application/json")
                );
        
            this.productFactory = new ProductFactory(this);
            this.reviewFactory = new ReviewFactory();

        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            IEnumerable<Product> products = new List<Product>();
            
            HttpResponseMessage response = await this.client.GetAsync(this.ProductsBaseUri);
            if (response.IsSuccessStatusCode)
            {
                // Build JToken
                byte[] JSON = await response.Content.ReadAsByteArrayAsync();
                string s = System.Text.Encoding.UTF8.GetString(JSON, 0, JSON.Length);
                JToken jsonoracleProducts = JObject.Parse(s)["items"];
                
                // Convert from JToken to OracleProducts list 
                IEnumerable<OracleProduct> oracleProducts = jsonoracleProducts.ToObject<IEnumerable<OracleProduct>>();

                // Generate products from oracleProducts
                products = await this.productFactory.GerenateProducts(oracleProducts);
            }

            return products;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string category)
        {
            IEnumerable<Product> products = new List<Product>();

            HttpResponseMessage response = await this.client.GetAsync(String.Format("{0}/{1}", this.CategoriesBaseUri, category.ToLower()));
            if (response.IsSuccessStatusCode)
            {
                // Build JToken
                byte[] JSON = await response.Content.ReadAsByteArrayAsync();
                string s = System.Text.Encoding.UTF8.GetString(JSON, 0, JSON.Length);
                JToken jsonoracleProducts = JObject.Parse(s)["items"];

                // Convert from JToken to OracleProducts list 
                IEnumerable<OracleProduct> oracleProducts = jsonoracleProducts.ToObject<IEnumerable<OracleProduct>>();

                // Generate products from oracleProducts
                products = await this.productFactory.GerenateProducts(oracleProducts);
            }

            return products;
        }

        public async Task<Product> GetProductById(string id)
        {
            List<Product> products = new List<Product>();

            HttpResponseMessage response = await this.client.GetAsync(String.Format("{0}/{1}", this.ProductsBaseUri, id));
            if (response.IsSuccessStatusCode)
            {
                // Build JToken
                byte[] JSON = await response.Content.ReadAsByteArrayAsync();
                string s = System.Text.Encoding.UTF8.GetString(JSON, 0, JSON.Length);
                JToken jsonoracleProducts = JObject.Parse(s)["items"];

                // Convert from JToken to OracleProduct 
                IEnumerable<OracleProduct> oracleProducts = jsonoracleProducts.ToObject<IEnumerable<OracleProduct>>();

                // Generate product from oracleProduct
                products = (List<Product>) await this.productFactory.GerenateProducts(oracleProducts);
            }

            return products.Count > 0 ? products[0] : null ;
        }

        public async Task<IEnumerable<ProductReview>> GetProductReviews(string productid)
        {
            List<ProductReview> productReviews = new List<ProductReview>();

            HttpResponseMessage response = await this.client.GetAsync(String.Format("{0}/{1}/reviews", this.ProductsBaseUri, productid));
            if (response.IsSuccessStatusCode)
            {
                // Build JToken
                byte[] JSON = await response.Content.ReadAsByteArrayAsync();
                string s = System.Text.Encoding.UTF8.GetString(JSON, 0, JSON.Length);
                JToken jsonoracleproductreviews = JObject.Parse(s)["items"];

                IEnumerable<OracleProductReview> oracleProductReviews = jsonoracleproductreviews.ToObject<IEnumerable<OracleProductReview>>();

                // Generate product comment from oracle product comment
                productReviews = (List<ProductReview>)this.reviewFactory.GenerateReviews(oracleProductReviews);
            }

            return productReviews;
        }

        public async Task<ProductReview> GetProductReview(string productid, string reviewid)
        {
            List<ProductReview> productReviews = new List<ProductReview>();

            HttpResponseMessage response = await this.client.GetAsync(String.Format("{0}/{1}/reviews/{2}", this.ProductsBaseUri, productid, reviewid));
            if (response.IsSuccessStatusCode)
            {
                // Build JToken
                byte[] JSON = await response.Content.ReadAsByteArrayAsync();
                string s = System.Text.Encoding.UTF8.GetString(JSON, 0, JSON.Length);
                JToken jsonoracleproductreviews = JObject.Parse(s)["items"];

                IEnumerable<OracleProductReview> oracleProductReviews = jsonoracleproductreviews.ToObject<IEnumerable<OracleProductReview>>();

                // Generate product comment from oracle product comment
                productReviews = (List<ProductReview>)this.reviewFactory.GenerateReviews(oracleProductReviews);
            }

            return productReviews.Count > 0 ? productReviews[0] : null;
        }

        public async Task<IEnumerable<string>> GetProductImages(string productid)
        {
            List<string> images = new List<string>();

            HttpResponseMessage response = await this.client.GetAsync(String.Format("{0}/{1}/images", this.ProductsBaseUri, productid));
            if (response.IsSuccessStatusCode)
            {
                // Build JToken
                byte[] JSON = await response.Content.ReadAsByteArrayAsync();
                string s = System.Text.Encoding.UTF8.GetString(JSON, 0, JSON.Length);
                JToken jsonoracleproductimages = JObject.Parse(s)["items"];

                foreach (var image in jsonoracleproductimages)
                {
                    images.Add(image["image"].ToString());
                }
            }

            return images;
        }
    }
}

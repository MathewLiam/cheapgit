namespace cheapgit.DAL.Workers
{
    using cheapgit.DAL.Factories;
    using cheapgit.DAL.Factories.Interfaces;
    using cheapgit.DAL.Models;
    using cheapgit.DAL.Models.OracleServiceModels;
    using cheapgit.DAL.Workers.Interfaces;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Resources;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="OracleApiWorker" />.
    /// </summary>
    public class OracleApiWorker : IApiWorker
    {
        // Base uri path for products
        /// <summary>
        /// Gets the ProductsBaseUri.
        /// </summary>
        private string ProductsBaseUri
        {
            get { return "/products"; }
        }

        // Base uri for orders
        /// <summary>
        /// Gets the OrdersBaseUri.
        /// </summary>
        private string OrdersBaseUri
        {
            get { return "/orders"; }
        }

        /// <summary>
        /// Gets the CategoriesBaseUri.
        /// </summary>
        private string CategoriesBaseUri
        {
            get { return "/categories"; }
        }

        /// <summary>
        /// Defines the client.
        /// </summary>
        private HttpClient client;

        /// <summary>
        /// Defines the resourceManager.
        /// </summary>
        private ResourceManager resourceManager;

        /// <summary>
        /// Defines the productFactory.
        /// </summary>
        private IProductFactory productFactory;

        /// <summary>
        /// Defines the reviewFactory.
        /// </summary>
        private IReviewFactory reviewFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="OracleApiWorker"/> class.
        /// </summary>
        /// <param name="baseUri">The baseUri<see cref="string"/>.</param>
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

        /// <summary>
        /// The GetProducts.
        /// </summary>
        /// <returns>The <see cref="Task{IEnumerable{Product}}"/>.</returns>
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

        /// <summary>
        /// The GetProductsByCategory.
        /// </summary>
        /// <param name="category">The category<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{Product}}"/>.</returns>
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

        /// <summary>
        /// The GetProductById.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{Product}"/>.</returns>
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
                products = (List<Product>)await this.productFactory.GerenateProducts(oracleProducts);
            }

            return products.Count > 0 ? products[0] : null;
        }

        /// <summary>
        /// The GetProductReviews.
        /// </summary>
        /// <param name="productid">The productid<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{ProductReview}}"/>.</returns>
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

        /// <summary>
        /// The GetProductReview.
        /// </summary>
        /// <param name="productid">The productid<see cref="string"/>.</param>
        /// <param name="reviewid">The reviewid<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{ProductReview}"/>.</returns>
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

        /// <summary>
        /// The GetProductImages.
        /// </summary>
        /// <param name="productid">The productid<see cref="string"/>.</param>
        /// <returns>The <see cref="Task{IEnumerable{string}}"/>.</returns>
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

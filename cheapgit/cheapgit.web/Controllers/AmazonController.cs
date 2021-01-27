namespace cheapgit.web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;

    [ApiController]
    public class AmazonController : ControllerBase
    { 
        private readonly IConfiguration _config;

        /// <summary>
        /// Initializes a new instance of the <see cref="AmazonController"/>.
        /// </summary>
        /// <param name="config"></param>
        public AmazonController(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Get the product category page by Amazon Site Url.
        /// </summary>
        /// <param name="category">The category to search results by</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/v1/amazon/search")]
        public async Task<JObject> GetResultByUrl(string searchterm, int? categoryid)
        {
            if (string.IsNullOrEmpty(searchterm))
            {
                throw new ArgumentNullException(nameof(searchterm));
            }
                
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(_config["AmazonApiBaseAddress"])
            };

            var result = await client.GetAsync($"?api_key={_config["AmazonProductApiKey"]}&type=search&search_term={searchterm}&amazon_domain=amazon.co.uk").ConfigureAwait(true);
            var content = result.Content.ReadAsStringAsync().Result;

            var response = JObject.Parse(content);
            return response;
        }
    }
}
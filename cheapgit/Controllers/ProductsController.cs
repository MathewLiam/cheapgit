using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using cheapgit.ViewModels.pages;
using cheapgit.DAL.Workers;
using cheapgit.DAL.Workers.Interfaces;
using System.Threading.Tasks;
using cheapgit.DAL.Models;
using System.Configuration;

namespace cheapgit.Controllers
{
    public class ProductsController : Umbraco.Web.Mvc.RenderMvcController
    {
        private IApiWorker _oracleApiWorker = new OracleApiWorker(ConfigurationSettings.AppSettings.Get("OcelotAPIGateway"));

        // GET: Products
        public async Task<ActionResult> Index(ContentModel content)
        {
            var categories = content.Content.GetProperty("categories").GetValue();

            List<Product> productslist = new List<Product>();

            foreach (var category in (string[]) categories)
            {
                var categoryProducts = await _oracleApiWorker.GetProductsByCategory(category);
                productslist.AddRange(categoryProducts);
            }

            var model = new ProductList(content.Content)
            {
                products = productslist
            };

            return CurrentTemplate(model);
        }

    }
        
}
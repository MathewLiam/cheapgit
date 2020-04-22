﻿using cheapgit.DAL.Workers;
using cheapgit.DAL.Workers.Interfaces;
using cheapgit.ViewModels.pages;
using System.Threading.Tasks;
﻿using cheapgit.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using System.Configuration;

namespace cheapgit.Controllers
{
    public class ProductDetailsController : Umbraco.Web.Mvc.RenderMvcController
    {
        IApiWorker _oracleApiWorker = new OracleApiWorker(ConfigurationSettings.AppSettings.Get("OcelotAPIGateway"));
        // GET: Products
        public async Task<ActionResult> Index(ContentModel content, string id)
        {
            var model = new ProductDetailsViewModel(content.Content)
            {
                product = await _oracleApiWorker.GetProductById(id),
                reviews = await _oracleApiWorker.GetProductReviews(id),
                images = await _oracleApiWorker.GetProductImages(id)
            };

            return CurrentTemplate(model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cheapgit.web.Controllers
{
    public class SearchController : Controller
    {
        [Route("search")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
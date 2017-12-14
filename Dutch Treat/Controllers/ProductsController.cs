using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Data
{

    public class ProductsController : Controller
    {
        public ProductsController(IDutchRepository repo)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
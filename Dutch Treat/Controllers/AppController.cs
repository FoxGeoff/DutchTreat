using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dutch_Treat.Data;

namespace Dutch_Treat.Controllers
{
    public class AppController : Controller
    {
        private readonly IDutchRepository _repository;

        public AppController(IDutchRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Shop()
        {  
            var results = _repository.GetAllProducts();

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
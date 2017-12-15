using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dutch_Treat.Data.Entities;

namespace Dutch_Treat.Data
{
    [Route("api/[Controller]")]
    public class ProductsController : Controller
    {
        private readonly IDutchRepository _repo;

        public ProductsController(IDutchRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllProducts());
            }
            catch (Exception ex)
            {
                //TODO Add logging
                // _logger.LogErrors($"Failed to get products: {ex}");

                return BadRequest("Failed to get products");
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
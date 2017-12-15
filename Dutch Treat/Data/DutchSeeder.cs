using Dutch_Treat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Dutch_Treat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _dutchContext;
        private readonly IHostingEnvironment _hosting;

        public DutchSeeder(DutchContext dutchContext, IHostingEnvironment hosting)
        {
            _dutchContext = dutchContext;
            _hosting = hosting;
        }

        public void Seed()
        {
            _dutchContext.Database.EnsureCreated();

            if (!_dutchContext.Products.Any())
            {
                //create sample data
                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _dutchContext.Products.AddRange(products);

                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = "GF001",
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    }       
                };
                _dutchContext.Add(order);
                _dutchContext.SaveChanges();
            }
        }
    }
}

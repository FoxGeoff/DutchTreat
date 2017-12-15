using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dutch_Treat.Data.Entities;

namespace Dutch_Treat.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext _context;

        public DutchRepository(DutchContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products
                .OrderBy(p => p.Title)
                .ToList();
        }
    }
}

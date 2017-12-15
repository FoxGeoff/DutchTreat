using System.Collections.Generic;
using Dutch_Treat.Data.Entities;

namespace Dutch_Treat.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
}
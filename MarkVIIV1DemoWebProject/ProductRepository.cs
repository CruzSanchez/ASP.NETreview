using Dapper;
using MarkVIIV1DemoWebProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MarkVIIV1DemoWebProject
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}

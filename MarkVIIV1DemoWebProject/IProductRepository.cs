using MarkVIIV1DemoWebProject.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkVIIV1DemoWebProject
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        
        //public Product GetProduct(int id);

    }
    
}

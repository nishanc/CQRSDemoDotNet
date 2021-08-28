using System.Collections.Generic;
using System.Threading.Tasks;
using CQRSDemo.Models;

namespace CQRSDemo.Data
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
    }
}
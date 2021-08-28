using CQRSDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository) => _productRepository = productRepository;

        /// <summary>
        /// Get all products.
        /// </summary>
        // GET api/products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var values  = await _productRepository.GetProducts();
            return Ok(values);
        }

    }
}

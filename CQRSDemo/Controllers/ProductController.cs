using CQRSDemo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRSDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator) => _mediator = mediator;

        /// <summary>
        /// Get product by id.
        /// </summary>
        // GET api/product/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var response  = await _mediator.Send(new GetProduct.Query(id));
            return response == null ? NotFound() : Ok(response);
        }
    }
}

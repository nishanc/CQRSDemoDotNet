using System.Threading;
using System.Threading.Tasks;
using CQRSDemo.Data;
using MediatR;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemo.Queries
{
    public static class GetProduct
    {
        // Query
        public record Query(int id) : IRequest<Response>;

        // Handler
        public class Handler : IRequestHandler<Query, Response>
        {
            public DataContext _context { get; }
            public Handler(DataContext _context) => this._context = _context;

            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                var product =  await _context.Products.FirstOrDefaultAsync(p => p.Id == request.id);
                return product == null ? null : new Response(product.Id, product.ProductName, product.Description);
            }
        }

        // Respose
        public record Response(int Id, string ProductName, string Description);
    }
}
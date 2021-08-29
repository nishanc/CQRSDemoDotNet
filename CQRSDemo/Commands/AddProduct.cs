using System.Threading;
using System.Threading.Tasks;
using CQRSDemo.Data;
using CQRSDemo.Models;
using MediatR;

namespace CQRSDemo.Commands
{
    public static class AddProduct
    {
        // Command
        public record Command(ProductToAddDto product) : IRequest<int>;

        // Handler
        public class Handler : IRequestHandler<Command, int>
        {
            public DataContext _context { get; }
            public Handler(DataContext _context) => this._context = _context;

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var product = new Product {
                    ProductName = request.product.ProductName,
                    Description = request.product.Description
                };
                await _context.AddAsync(product);
                if(await _context.SaveChangesAsync() > 0) {
                    return product.Id;
                } else {
                    return 0;
                }
            }
        }
    }
}
using DesignPattern.CQRS.CQRSPattern.Result;
using DesignPattern.CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.CQRS.CQRSPattern.Handler
{
    public class GetProductQueryHandler
    {
        private readonly VtContext _context;

        public GetProductQueryHandler(VtContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                //result dan gelen değer entity değerlere eşledik
                ProductId= x.ProductId,
                Price= x.Price,
                ProductName = x.Name,
                Stock = x.Stock,
            }).ToList();

            return values;
        }
    }
}

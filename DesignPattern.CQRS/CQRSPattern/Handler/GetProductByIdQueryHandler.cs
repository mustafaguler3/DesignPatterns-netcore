using DesignPattern.CQRS.CQRSPattern.Query;
using DesignPattern.CQRS.CQRSPattern.Result;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler
{
    public class GetProductByIdQueryHandler
    {
        private readonly VtContext _context;

        public GetProductByIdQueryHandler(VtContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);

            return new GetProductByIdQueryResult
            {
                Name = values.Name,
                Price= values.Price,
                ProductId= values.ProductId,
                Stock = values.Stock
            };
        }
    }
}

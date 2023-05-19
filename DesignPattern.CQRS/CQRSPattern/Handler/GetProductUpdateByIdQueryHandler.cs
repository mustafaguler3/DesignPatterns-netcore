using DesignPattern.CQRS.CQRSPattern.Query;
using DesignPattern.CQRS.CQRSPattern.Result;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly VtContext _context;

        public GetProductUpdateByIdQueryHandler(VtContext context)
        {
            _context = context;
        }

        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);

            return new GetProductUpdateQueryResult
            {
                Description = value.Description,
                Name = value.Name,
                Price = value.Price,
                ProductId = value.ProductId,
                Stock = value.Stock,
            };
        }
    }
}

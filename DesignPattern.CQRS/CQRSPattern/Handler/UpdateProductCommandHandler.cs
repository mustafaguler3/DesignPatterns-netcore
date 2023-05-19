using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler
{
    public class UpdateProductCommandHandler
    {
        private readonly VtContext _context;

        public UpdateProductCommandHandler(VtContext context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductId);

            values.Name = command.Name;
            values.Description = command.Description;
            values.ProductId = command.ProductId;
            values.Price = command.Price;
            values.Stock = command.Stock;

            _context.SaveChanges();
        }
    }
}

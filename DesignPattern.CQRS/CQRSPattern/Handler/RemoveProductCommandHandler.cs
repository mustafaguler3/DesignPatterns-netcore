using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler
{
    public class RemoveProductCommandHandler
    {
        private readonly VtContext _context;

        public RemoveProductCommandHandler(VtContext context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var value = _context.Products.Find(command.Id);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}

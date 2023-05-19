using DesignPatterns.ObserverPattern.DAL;
using System;

namespace DesignPatterns.ObserverPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        VtContext context = new VtContext();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "magazine2023",
                DiscountAmount = 50,
                Status = true
            });
            context.SaveChanges();
        }
    }
}

using DesignPatterns.ObserverPattern.DAL;
using System;

namespace DesignPatterns.ObserverPattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        VtContext context = new VtContext();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "thank you for registering",
            });

            context.SaveChanges();
        }
    }
}

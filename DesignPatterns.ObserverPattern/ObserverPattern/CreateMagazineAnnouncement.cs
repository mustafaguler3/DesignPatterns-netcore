using DesignPatterns.ObserverPattern.DAL;
using System;

namespace DesignPatterns.ObserverPattern.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider serviceProvider;
        VtContext context = new VtContext();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Fiction magazine",
                Content = ""
            });
            context.SaveChanges();
        }
    }
}

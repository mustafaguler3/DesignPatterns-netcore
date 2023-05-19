using DesignPatterns.ObserverPattern.DAL;

namespace DesignPatterns.ObserverPattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}

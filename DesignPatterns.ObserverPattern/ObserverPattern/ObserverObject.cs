using DesignPatterns.ObserverPattern.DAL;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observer;

        public ObserverObject()
        {
            _observer = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observer.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observer.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser)
        {
            _observer.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            });
        }
    }
}

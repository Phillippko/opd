
using System.Collections.Generic;
using System.Threading;

    public class CentralElectionCommission {
        List<Observer> observers = new List<Observer>();

        public void subscribe(Observer observer)
        {
            observers.Add(observer);
        }
        public void notify(int delay, string message) {
            Thread.Sleep(delay);
            foreach (var observer in observers)
            {
                observer.display(message);
            }
        }
    }
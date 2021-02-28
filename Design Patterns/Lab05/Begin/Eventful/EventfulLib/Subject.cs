using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventfulLib
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}

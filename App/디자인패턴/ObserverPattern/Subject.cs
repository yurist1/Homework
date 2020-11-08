using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Subject
    {
        List<IUpdate> observers = new List<IUpdate>();
        public void AddObserver(IUpdate observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IUpdate observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IUpdate observer in observers)
            {
                observer.Update();
            }
        }
    }
}

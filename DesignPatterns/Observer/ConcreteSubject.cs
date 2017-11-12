using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public string SubjectState { get; private set; }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in observers)
            {
                o.Update();
            }
        }

        public void ChangeState(string state)
        {
            SubjectState = state;
        }

    }
}

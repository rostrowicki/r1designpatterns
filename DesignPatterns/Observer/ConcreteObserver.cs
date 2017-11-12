using System;

namespace DesignPatterns.Observer
{
    public class ConcreteObserver : IObserver
    {
        string ObserverId;
        ConcreteSubject Subject;

        public ConcreteObserver(string observerId, ISubject subject)
        {
            ObserverId = observerId;
            Subject = (ConcreteSubject)subject;
        }

        public void Update()
        {
            Console.WriteLine($"Current State in {ObserverId}: {Subject.SubjectState}");
        }
    }
}

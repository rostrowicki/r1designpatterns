using DesignPatterns.Observer;
using System.Threading;

namespace DesignPatterns
{
    public class ObserverPattern
    {
        public ObserverPattern()
        {
            ConcreteSubject subject = new ConcreteSubject();

            ConcreteObserver observer1 = new ConcreteObserver("Rome", subject);
            ConcreteObserver observer2 = new ConcreteObserver("Paris", subject);
            ConcreteObserver observer3 = new ConcreteObserver("London", subject);

            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.Attach(observer3);

            for (int i = 0; i < 10; i++)
            {
                subject.ChangeState($"Status #{i}");
                subject.Notify();
                Thread.Sleep(500);
            }

        }
    }
}

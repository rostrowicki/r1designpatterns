using System;

namespace DesignPatterns.Strategy
{
    public class ConcreteStrategy1 : IStrategy
    {
        public void Task()
        {
            Console.WriteLine("Strategy 1");
        }
    }

}

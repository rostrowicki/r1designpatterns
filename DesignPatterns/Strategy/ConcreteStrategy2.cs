using System;

namespace DesignPatterns.Strategy
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void Task()
        {
            Console.WriteLine("Strategy 2");
        }
    }
}

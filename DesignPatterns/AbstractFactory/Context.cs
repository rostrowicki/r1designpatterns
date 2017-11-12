using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class Context
    {
        const string FACTORY1 = "F1";
        const string FACTORY2 = "F2";

        public static IAbstractFactory ChooseFactory(string name)
        {
            switch (name)
            {
                case FACTORY1:
                    return new ConcreteFactory1();                    
                case FACTORY2:
                    return new ConcreteFactory2();
                default:
                    return null;
            }
        }
    }
}

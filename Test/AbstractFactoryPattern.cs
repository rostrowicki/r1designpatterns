using DesignPatterns.AbstractFactory;
using System;

namespace Test
{
    class AbstractFactoryPattern
    {
        public AbstractFactoryPattern()
        {
            IAbstractFactory factory1 = Context.ChooseFactory("F1");
            IAbstractFactory factory2 = Context.ChooseFactory("F2");

            IAbstractProduct product1 = factory1.CreateProduct();
            IAbstractProduct product2 = factory2.CreateProduct();

            Console.WriteLine(product1.GetName());
            Console.WriteLine(product2.GetName());
        }
    }
}

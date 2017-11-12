namespace DesignPatterns.AbstractFactory
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public string Name { get; set; }

        public ConcreteFactory2()
        {
            Name = "Factory 2";
        }

        public IAbstractProduct CreateProduct()
        {
            return new ConcreteProduct2("P2");
        }
    }
}

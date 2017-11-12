namespace DesignPatterns.AbstractFactory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public string Name { get; set; }

        public ConcreteFactory1()
        {
            Name = "Factory 1";
        }

        public IAbstractProduct CreateProduct()
        {
            return new ConcreteProduct1("P1");
        }
    }
}

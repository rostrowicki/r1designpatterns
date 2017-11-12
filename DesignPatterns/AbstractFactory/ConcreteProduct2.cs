namespace DesignPatterns.AbstractFactory
{
    class ConcreteProduct2 : IAbstractProduct
    {
        private string Name { get; set; }

        public ConcreteProduct2(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

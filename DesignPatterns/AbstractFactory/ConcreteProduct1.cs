namespace DesignPatterns.AbstractFactory
{
    class ConcreteProduct1 : IAbstractProduct
    {
        private string Name { get; set; }

        public ConcreteProduct1(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}

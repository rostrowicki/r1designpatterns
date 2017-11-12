namespace DesignPatterns.Strategy
{
    public class Context
    {
        private IStrategy Strategy { get; set; }

        public void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }

        public IStrategy GetStrategy()
        {
            return Strategy;
        }
    }
}

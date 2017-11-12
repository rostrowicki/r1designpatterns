using DesignPatterns.Strategy;

namespace Test
{
    public class StrategyPattern
    {

        public StrategyPattern()
        {
            Context ctx = new Context();

            ctx.SetStrategy(new ConcreteStrategy1());
            ctx.GetStrategy().Task();

            ctx.SetStrategy(new ConcreteStrategy2());
            ctx.GetStrategy().Task();

            ctx.SetStrategy(new ConcreteStrategy3());
            ctx.GetStrategy().Task();

        }

    }
}

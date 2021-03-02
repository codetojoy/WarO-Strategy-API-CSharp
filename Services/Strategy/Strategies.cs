using System;

namespace SampleAPI.Services.Strategy
{
    public class Strategies
    {
        public IStrategy GetStrategy(string name)
        {
            IStrategy strategy = null;

            switch (name.Trim().ToLower())
            {
                case StrategyConstants.STRATEGY_MAX:
                    strategy = new MaxCard();
                    break;
                case StrategyConstants.STRATEGY_MIN:
                    strategy = new MinCard();
                    break;
                case StrategyConstants.STRATEGY_NEAREST:
                    strategy = new NearestCard();
                    break;
                case StrategyConstants.STRATEGY_NEXT:
                    strategy = new NextCard();
                    break;
                default:
                    throw new Exception("unknown strategy");
            }

            return strategy;
        }
    }
}

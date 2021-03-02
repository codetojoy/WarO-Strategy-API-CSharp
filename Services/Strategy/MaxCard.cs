using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleAPI.Services.Strategy
{
    public class MaxCard : IStrategy
    {
        public string GetName() {
            return StrategyConstants.STRATEGY_MAX;
        }
       public int SelectCard(int prizeCard, IList<int> hand, int maxCard) {
           return hand.Max(i => i);
       }
    }
}

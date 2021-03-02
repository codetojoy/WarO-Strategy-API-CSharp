﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleAPI.Services.Strategy
{
    public class MinCard : IStrategy
    {
        public string GetName() {
            return StrategyConstants.STRATEGY_MIN;
        }
       public int SelectCard(int prizeCard, IList<int> hand, int maxCard) {
           return hand.Min(i => i);
       }
    }
}

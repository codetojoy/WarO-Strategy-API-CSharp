using System;
using System.Collections.Generic;

namespace SampleAPI.Services.Strategy
{
    public interface IStrategy
    {
        string GetName();
        int SelectCard(int prizeCard, IList<int> hand, int maxCard);
    }
}

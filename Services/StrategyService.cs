using System;
using System.Collections.Generic;

using SampleAPI.Services.Strategy;

namespace SampleAPI.Services
{
    public interface IStrategyService
    {
        void DoPathologicalDelay(int delayInSeconds);
        string SelectCard(string mode, int prizeCard, int maxCard, IList<int> cards);
    }

    public class StrategyService : IStrategyService
    {
        public void DoPathologicalDelay(int delayInSeconds)
        {
            var delayInMillis = delayInSeconds * 1000;
            System.Threading.Thread.Sleep(delayInMillis);
        }
        public string SelectCard(string mode, int prizeCard, int maxCard, IList<int> cards)
        {
            var strategy = new Strategies().GetStrategy(mode);
            var card = strategy.SelectCard(prizeCard, cards, maxCard);
            var threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
            var now = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
            var q = "\"";
            var message = $"{q}TRACER ({threadId}) {now} OK{q}";
            return "{" + $"{q}card{q}: {card}, {q}message{q}: {message}" + "}";
        }
    }
}

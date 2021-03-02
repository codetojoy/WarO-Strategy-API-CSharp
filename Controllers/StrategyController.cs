using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using SampleAPI.Services;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("waro/[controller]")]
    public class StrategyController : ControllerBase
    {
        private const string whoAmI = "StrategyController";
        private readonly ILogger<WeatherForecastController> _logger;

        public StrategyController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _logger.LogInformation($"TRACER hello from {whoAmI} ctor");
        }

        [HttpGet]
        public ActionResult<string> Get(
            [FromServices]IStrategyService strategyService,
            [FromQuery(Name = "mode")] string mode,
            [FromQuery(Name = "prize_card")] int prizeCard,
            [FromQuery(Name = "max_card")] int maxCard,
            [FromQuery(Name = "cards")] List<int> cards,
            [FromQuery(Name = "delay_in_seconds")] int delayInSeconds = 0)
        {
            _logger.LogInformation($"TRACER hello from {whoAmI} GET");

            if (delayInSeconds > 0)
            {
                strategyService.DoPathologicalDelay(delayInSeconds);
            }

            return strategyService.SelectCard(mode, prizeCard, maxCard, cards);
        }
    }
}

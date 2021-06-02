using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightsApi
{
    [ApiController]
    [Route("[controller]")]
    public class FlightOrder : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "flight1", "Flight2"
        };

        private readonly ILogger<FlightOrder> _logger;

        public FlightOrder(ILogger<FlightOrder> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Flight
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

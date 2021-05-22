using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ispat.Controllers
{
    [ApiController]
    [Route("Copyright")]
    public class LaunchController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Copyright Reserved @ Naimul, Bulbul & Mahmud"
        };

        private readonly ILogger<LaunchController> _logger;

        public LaunchController(ILogger<LaunchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Array Get()
        {
            var rng = new Random();
            return Summaries;
        }
    }
}

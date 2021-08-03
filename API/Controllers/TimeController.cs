using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController
    {
        private readonly ILogger<TimeController> _logger;

        public TimeController(ILogger<TimeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public DateTime Get() => DateTime.Now;
    }
}

using CO2RedBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CO2RedBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CO2RedController : ControllerBase
    {
        private readonly ILogger<ConsumptionController> _logger;
        private readonly CO2RedDataContext _dbContext;
        public CO2RedController(ILogger<ConsumptionController> logger, CO2RedDataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetCo2ReductionByUser")]
        public IActionResult GetCo2ReductionByUser([FromQuery] long userId)
        {
            return Ok(_dbContext.CO2Reds.Where(c => c.UserId == userId).ToList());

        }


    }
}

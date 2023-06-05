using CO2RedBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CO2RedBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanController : ControllerBase
    {
        private readonly ILogger<ConsumptionController> _logger;
        private readonly CO2RedDataContext _dbContext;

        public PlanController(ILogger<ConsumptionController> logger, CO2RedDataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetPlans")]
        public IActionResult GetAllPlans()
        {
            return Ok(_dbContext.Plans.ToList());

        }
    }
}

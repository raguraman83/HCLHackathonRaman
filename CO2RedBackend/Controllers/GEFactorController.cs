using CO2RedBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CO2RedBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GEFactorController : ControllerBase
    {
        private readonly ILogger<GEFactorController> _logger;
        private readonly CO2RedDataContext _dbContext;

        public GEFactorController(ILogger<GEFactorController> logger, CO2RedDataContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetGEFactors")]
        public IActionResult GetAllGEFactors()
        {
            return Ok(_dbContext.GEFactors.ToList());

        }
    }
}

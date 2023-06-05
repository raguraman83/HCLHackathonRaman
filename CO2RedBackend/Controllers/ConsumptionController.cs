using Azure;
using CO2RedBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CO2RedBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumptionController : ControllerBase
    {
        private readonly ILogger<ConsumptionController> _logger;
        private readonly CO2RedDataContext _dbContext;


        public ConsumptionController(ILogger<ConsumptionController> logger,CO2RedDataContext dbContext)
        {
            _logger = logger;
            _dbContext  = dbContext;
        }

        [HttpGet(Name = "GetConsumption")]
        public IActionResult GetConsumption([FromQuery]long userId)
        {
            return Ok( _dbContext.ElectricConsumptions.Where(c => c.UserId == userId).ToList());
            
        }

       // [HttpPost]
        //public async Task<IActionResult> AddConsumption(AddContactRequest addContactRequest)
        //{
        //    var contact = new Contact()
        //    {
        //        id = Guid.NewGuid(),
        //        name = addContactRequest.Name,
        //        address = addContactRequest.Address,
        //        email = addContactRequest.Email,
        //        phone = addContactRequest.Phone,
        //    };
        //    await dbContext.Contacts.AddAsync(contact);
        //    await dbContext.SaveChangesAsync();
        //    return Ok(contact);
        //}
    }
}

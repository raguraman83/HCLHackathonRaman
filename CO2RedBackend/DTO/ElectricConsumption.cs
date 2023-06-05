using CO2RedBackend.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO2RedBackend.DTO
{
    public class ElectricConsumption
    {
        public long ID { get; set; }
        public long UserId { get; set; }

        public uint Year { get; set; }

        public uint Month { get; set; }

        public uint ConsumptionKWH { get; set; }

        public User User { get; set; }
    }
}

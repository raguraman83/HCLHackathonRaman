using System.ComponentModel.DataAnnotations;

namespace CO2RedBackend.DTO
{
    public class GEFactor
    {
        public long ID { get; set; }

        public uint Year { get; set; }
        public uint Month { get; set; }
        public string CountryCode { get; set; }
        public decimal CO2Factor { get; set; }
    }
}

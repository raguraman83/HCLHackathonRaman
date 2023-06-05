using System.ComponentModel.DataAnnotations.Schema;

namespace CO2RedBackend.DTO
{
    public class CO2Red
    {
        public long ID { get; set; }
        public long UserId { get; set; }

        public uint CO2 { get; set; }

        public User User { get; set; }
    }
}

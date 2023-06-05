using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO2RedBackend.Models
{
    [Table("ELECTRIC_CONSUMPTION")]
    public class ElectricConsumption
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }

        public uint Year { get; set; }

        public uint Month { get; set; }

        public uint ConsumptionKWH  { get; set; }

        public User User { get; set; }
    }
}

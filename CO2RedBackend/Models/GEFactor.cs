using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CO2RedBackend.Models
{
    [Table("GEFACTOR")]
    public class GEFactor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public uint Year { get; set; } 
        public uint Month { get; set; }

        [MaxLength(10)]
        public string CountryCode { get; set; }  
        public decimal CO2Factor { get; set; }

    }
}


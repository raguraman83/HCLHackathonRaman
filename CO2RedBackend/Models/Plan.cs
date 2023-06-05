using CO2RedBackend.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO2RedBackend.Models
{
    [Table("PLAN")]
    public class Plan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        
        [ForeignKey(nameof(CO2Red))]
        public long CoidId { get; set; }

        [MaxLength(100)]
        public string PlanName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string PlanDescriptions { get; set; } = string.Empty;

        public uint ReductionInKWH { get; set; }


    }
}



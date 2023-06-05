using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO2RedBackend.Models
{
    [Table("CO2RED")]
    public class CO2Red
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [ForeignKey(nameof(User))]
        public long UserId { get; set; }

        public uint CO2 { get; set; }

        public uint Year { get; set; }

        public User User { get; set; }

        public List<Plan> Plans { get; set; }
    }
}

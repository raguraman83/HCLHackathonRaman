using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO2RedBackend.Models
{
    [Table("USER")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        
        public string FirstName { get; set; } = string.Empty;
        public string? MidleName { get; set; } = null;
        public string MastName { get; set; } = string.Empty;
        public DateTime? DOB { get; set;} = null;

        [MaxLength(50)]
        public string Country { get; set; } = string.Empty;

        [MaxLength(12)]
        public string Mobile { get; set; } = string.Empty;

        [MaxLength(500)]
        public string ResAddress { get; set; } = string.Empty;

        [MaxLength(500)]
        public string WorkAddress { get; set; } = string.Empty;

        public uint NoOfFamilyMembers { get; set; }




    }
}




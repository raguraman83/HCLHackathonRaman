using System.ComponentModel.DataAnnotations;

namespace CO2RedBackend.DTO
{
    public class User
    {
        public long ID { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string? MidleName { get; set; } = null;
        public string MastName { get; set; } = string.Empty;
        public DateTime? DOB { get; set; } = null;
        public string Country { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;

        public string ResAddress { get; set; } = string.Empty;

        public string WorkAddress { get; set; } = string.Empty;

        public uint NoOfFamilyMembers { get; set; }
    }
}

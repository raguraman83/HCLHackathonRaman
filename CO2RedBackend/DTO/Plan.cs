using System.ComponentModel.DataAnnotations;

namespace CO2RedBackend.DTO
{
    public class Plan
    {
        public long ID { get; set; }
        public string PlanName { get; set; } = string.Empty;
        public string PlanDescriptions { get; set; } = string.Empty;

        public uint ReductionInKWH { get; set; }
    }
}

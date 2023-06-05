using AutoMapper;

namespace CO2RedBackend.Models
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<ElectricConsumption, DTO.ElectricConsumption>();
            CreateMap<User, DTO.User>();
            CreateMap<CO2Red, DTO.CO2Red>();
            CreateMap<GEFactor, DTO.GEFactor>();
            //CreateMap<UpdateEmpRequest, Employee>();

        }
    }
}

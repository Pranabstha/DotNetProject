using AutoMapper;
using BislariumCW.Dtos;
using BislariumCW.Models;

namespace BislariumCW.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<ApplicationUser, UserRegistrationDto>().ReverseMap();
        }
    }
}

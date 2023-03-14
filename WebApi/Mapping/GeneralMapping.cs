using AutoMapper;
using WebApi.Dto;
using WebApi.Models;

namespace WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();

        
        }
    }
}

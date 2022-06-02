using AutoMapper;
using Week2WebAPI.Core.DTO;
using Week2WebAPI.Core.Models;

namespace Week2WebAPI.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}

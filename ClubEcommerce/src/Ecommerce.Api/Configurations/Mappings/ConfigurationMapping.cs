using AutoMapper;
using Ecommerce.Api.Dtos;
using Ecommerce.Business.Models;

namespace Ecommerce.Api.Configurations.Mappings
{
    public class ConfigurationMapping : Profile
    {
        public ConfigurationMapping()
        {
            CreateMap<Product, CreateProductDto>().ReverseMap();
        }
    }
}

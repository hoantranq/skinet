using System.Collections.Generic;
using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(m => m.ProductBrand, o => o.MapFrom(p => p.ProductBrand.Name))
            .ForMember(m => m.ProductType, o => o.MapFrom(p => p.ProductType.Name))
            .ForMember(m => m.PictureUrl, o => o.MapFrom<ProductResolver>());
        }
    }
}
using AutoMapper;
using Saas.Dto.CatalogDto;
using Saas.Models;

namespace Saas.Mappings
{
    public class CatalogMap : Profile{
        public CatalogMap()
        {
            CreateMap<CatalogCreateDto, Catalog>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.TemplateId))
                .ForMember(dest => dest.CustomDomain, opt => opt.MapFrom(src => src.CustomDomain))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));

            CreateMap<Catalog, CatalogResponseDto>()
                .ForMember(dest => dest.CatalogId, opt => opt.MapFrom(src => src.CatalogId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.TemplateId, opt => opt.MapFrom(src => src.TemplateId))
                .ForMember(dest => dest.CustomDomain, opt => opt.MapFrom(src => src.CustomDomain))
                .ForMember(dest => dest.TenantId, opt => opt.MapFrom(src => src.TenantId));
        }
    }
}

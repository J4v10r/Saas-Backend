using AutoMapper;
using Saas.Dto.UserDto;
using Saas.Models;

namespace Saas.Mappings
{
    public class UserMap : Profile{
        public UserMap(){

            CreateMap<User, UserResponseDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.UserEmail, opt => opt.MapFrom(src => src.UserEmail))
                .ForMember(dest => dest.CatalogId, opt => opt.MapFrom(src => src.CatalogId));

            CreateMap<UserCreateDto, User>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
                .ForMember(dest => dest.UserEmail, opt => opt.MapFrom(src => src.UserEmail))
                .ForMember(dest => dest.UserPhone, opt => opt.MapFrom(src => src.UserPhone))
                .ForMember(dest => dest.UserCpf, opt => opt.MapFrom(src => src.UserCpf))
                .ForMember(dest => dest.CatalogId, opt => opt.MapFrom(src => src.CatalogId));
        
        }
    }
}

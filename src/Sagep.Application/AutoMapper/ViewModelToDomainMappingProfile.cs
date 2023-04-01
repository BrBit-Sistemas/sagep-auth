using AutoMapper;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models;

namespace Sagep.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ApplicationUserGroupViewModel, ApplicationUserGroup>();
            CreateMap<ApplicationUserGroupUpdateViewModel, ApplicationUserGroup>();
            CreateMap<ApplicationUserViewModel, ApplicationUserGroup>()
                .ForMember(dst => dst.UserId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationUserViewModel, ApplicationUser>()
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups))
                .ForMember(dst => dst.UserName, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.NormalizedUserName, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.NormalizedEmail, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.EmailConfirmed, src => src.MapFrom(x => x.EmailConfirmed))
                .ForMember(dst => dst.LockoutEnabled, src => src.MapFrom(x => x.LockoutEnabled))
                .ForMember(dst => dst.Avatar, src => src.MapFrom(x => x.Avatar))
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.Status));
            CreateMap<ApplicationUserUpdateViewModel, ApplicationUser>()
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups))
                .ForMember(dst => dst.UserName, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.NormalizedUserName, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.NormalizedEmail, src => src.MapFrom(x => x.Email.ToUpper()))
                .ForMember(dst => dst.EmailConfirmed, src => src.MapFrom(x => x.EmailConfirmed))
                .ForMember(dst => dst.LockoutEnabled, src => src.MapFrom(x => x.LockoutEnabled))
                .ForMember(dst => dst.Avatar, src => src.MapFrom(x => x.Avatar))
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.Status));
            CreateMap<ApplicationRoleViewModel, ApplicationRole>();
            CreateMap<ApplicationGroupViewModel, ApplicationGroup>();
            CreateMap<ApplicationRoleGroupViewModel, ApplicationRoleGroup>();
            CreateMap<ApplicationRoleViewModel, ApplicationRole>();
            CreateMap<DetentoViewModel, Detento>();
        }
    }
}

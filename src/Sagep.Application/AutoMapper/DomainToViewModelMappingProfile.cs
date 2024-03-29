﻿using System.Linq;
using AutoMapper;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Select;
using Sagep.Domain.Models;

namespace Sagep.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ApplicationUserGroup, ApplicationUserGroupViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.ApplicationGroup.Name));
            CreateMap<ApplicationUserGroup, ApplicationUserGroupViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.ApplicationGroup.Name));
            CreateMap<ApplicationUser, ApplicationUserViewModel>()
                .ForMember(dst => dst.Email, src => src.MapFrom(x => x.Email))
                .ForMember(dst => dst.FullName, src => src.MapFrom(x => x.FullName))
                .ForMember(dst => dst.UserName, src => src.MapFrom(x => x.UserName))
                .ForMember(dst => dst.Avatar, src => src.MapFrom(x => x.Avatar))
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups));
            CreateMap<ApplicationUser, UsuarioInfoViewModel>();
            CreateMap<ApplicationUser, UsuarioContaViewModel>()
                .ForMember(dst => dst.ApplicationUserGroups, src => src.MapFrom(x => x.ApplicationUserGroups));
            CreateMap<ApplicationGroup, ApplicationGroupUpdateViewModel>();
            CreateMap<ApplicationRole, ApplicationRoleSelect2ViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.RoleId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationRole, ApplicationRoleViewModel>();
            CreateMap<ApplicationGroup, ApplicationGroupViewModel>()
                .ForMember(dst => dst.Status, src => src.MapFrom(x => x.IsDeleted ? "INACTIVE" : "ACTIVE"))
                .ForMember(dst => dst.ApplicationRoleGroupsNames, src => src.MapFrom(x => x.ApplicationRoleGroups.Select(x => x.ApplicationRole.Name)));
            CreateMap<ApplicationGroup, ApplicationGroupSelect2ViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.Name))
                .ForMember(dst => dst.GroupId, src => src.MapFrom(x => x.Id));
            CreateMap<ApplicationRoleGroup, ApplicationRoleGroupViewModel>()
                .ForMember(dst => dst.Name, src => src.MapFrom(x => x.ApplicationRole.Name));
        }
    }
}
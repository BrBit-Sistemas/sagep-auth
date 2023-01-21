using AutoMapper;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models;

namespace Sagep.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserViewModel>()
                .ForMember(dst => dst.UserId, src => src.MapFrom(x => x.Id));
        }
    }
}
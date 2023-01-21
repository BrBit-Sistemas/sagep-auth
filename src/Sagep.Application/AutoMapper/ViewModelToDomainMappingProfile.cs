using AutoMapper;
using Sagep.Application.ViewModels;
using Sagep.Domain.Models;
using Sagep.Application.Extensions;

namespace Sagep.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ApplicationUserViewModel, ApplicationUser>();
        }
    }
}

using System.Collections.Generic;

namespace Sagep.Application.ViewModels
{
    public class ApplicationRoleGroupUpdateViewModel
    {
        public string RoleId { get;set; }
        public string GroupId { get;set; }
        public string Name { get; set; }

        public List<ApplicationRoleGroupUpdateViewModel> ApplicationRoleGroups { get; set; }
    }
}
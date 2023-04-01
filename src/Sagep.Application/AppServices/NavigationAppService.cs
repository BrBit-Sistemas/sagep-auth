using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Sagep.Application.Interfaces;
using Sagep.Application.ViewModels;

namespace Sagep.Application.AppServices
{
    public class NavigationAppService : INavigationAppService
    {
        public NavigationAppService() {  }

        public async Task<IEnumerable<VerticalNavItemViewModel>> MyMenuAsync(string userId)
        {
            #region Required validations
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentException("Id usuário requerido.");
            #endregion

            #region Get and mapper object
            var navigation = new List<VerticalNavItemViewModel>();
            var navigationA = new VerticalNavItemViewModel();
            var navigationSectionA = new VerticalNavItemViewModel();
            var navigationSectionB = new VerticalNavItemViewModel();
            var navigationB = new VerticalNavItemViewModel();
            var navigationF = new VerticalNavItemViewModel();
            var navigationG = new VerticalNavItemViewModel();
            
            navigationA.Children = new List<Son>();
            navigationB.Children = new List<Son>();
            navigationF.Children = new List<Son>();
            navigationG.Children = new List<Son>();

            var oldestDashboardSonA = new Son();
            var oldestDashboardSonB = new Son();
            var oldestSonB = new Son();
            var oldestSonC = new Son();
            var oldestSonD = new Son();

            navigationA = new VerticalNavItemViewModel
            {
                Title = "Dashboards",
                Icon = "HomeAnalytics",
                BadgeContent = "novo",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            var publica = new Son
            {
                Title = "Pública",
                Path = "/dashboards/publica",
                Action = "list",
                Subject = "ac-dashboardPublica-page"
            };
            navigationA.Children.Add(publica);

            navigationB = new VerticalNavItemViewModel
            {
                Title = "Controle Acesso",
                Icon = "TrackpadLock",
                BadgeContent = "",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            oldestSonB = new Son
            {
                Title = "Usuários",
                Path = "/sistema/controle-acesso/usuario/list",
                Action = "list",
                Subject = "ac-user-page"
            };
            navigationB.Children.Add(oldestSonB);

            oldestSonC = new Son
            {
                Title = "Permissões",
                Path = "/sistema/controle-acesso/role/list",
                Action = "list",
                Subject = "ac-role-page"
            };
            navigationB.Children.Add(oldestSonC);

            oldestSonD = new Son
            {
                Title = "Grupos",
                Path = "/sistema/controle-acesso/grupo/list",
                Action = "list",
                Subject = "ac-group-page"
            };
            navigationB.Children.Add(oldestSonD);

            var navigationC = new VerticalNavItemViewModel
            {
                BadgeContent = "",
                Title = "Fiscal",
                Icon = "Domain",
                BadgeColor = "primary",
                Children = new List<Son>()
            };

            var notaFiscal = new Son()
            {
                Title = "Nota fiscal serviços",
                Path = "/fiscal/notaFiscal/list",
                Action = "list",
                Subject = "ac-nfse-page"
            };
            navigationC.Children.Add(notaFiscal);

            await Task.Run(() => navigation.Add(navigationA));
            await Task.Run(() => navigation.Add(navigationG));
            
            navigationSectionA = new VerticalNavItemViewModel
            {
                SectionTitle = "SYSTEM",
                Action = "list",
                Subject = "ac-sectionTitleSystem-page"
            };
            navigationSectionB = new VerticalNavItemViewModel
            {
                SectionTitle = "FISCAL",
                Action = "list",
                Subject = "ac-sectionTitleFiscal-page"
            };

            await Task.Run(() => navigation.Add(navigationSectionA));
            await Task.Run(() => navigation.Add(navigationB));
            await Task.Run(() => navigation.Add(navigationF));
            
            await Task.Run(() => navigation.Add(navigationSectionB));
            await Task.Run(() => navigation.Add(navigationC));
            #endregion
            
            return navigation.ToList();
        }
    }
}
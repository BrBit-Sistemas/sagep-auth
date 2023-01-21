using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Charts.Info;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface IColaboradorAppService : IDisposable
    {
        ColaboradorViewModel GetByIdWithInclude(Guid id);
        ValidationResult Add(ColaboradorViewModel colaboradorViewModel);
        ValidationResult Update(ColaboradorViewModel colaboradorViewModel);
        Generic2Select2ViewModel GetByDetentoIpenOrDetentoNome(string property, string arg);
        IEnumerable<ColaboradorViewModel> GetAll();
        IEnumerable<ColaboradorViewModel> AsNoTrackingWithInclude();
        Task<IEnumerable<ColaboradorViewModel>> GetAllAsync();
        IEnumerable<ColaboradorViewModel> GetAllSoftDeleted();
        ValidationResult Remove(Guid id);

        ColaboradorViewModel GetByDetentoIpenAndEmpresaConvenioId(int ipen, string ecId);

        //Métodos indicadores
        Task<ColaboradorPorConvenioViewModel> GetAllColaboradorPorConvenioSituacaoAdmitido();
    }
}
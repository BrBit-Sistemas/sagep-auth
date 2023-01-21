using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Detentos;
using Sagep.Application.ViewModels.Requests;
using Sagep.Application.ViewModels.Selects;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface ILivroAppService : IDisposable
    {
        Task<IEnumerable<LivroViewModel>> GetAllWithVRAsync();
        Task<ValidationResult> AddAsync(LivroViewModel livroViewModel);
        ValidationResult Remove(Guid id);
        Task<ValidationResult> UpdateAsync(LivroViewModel livroViewModel);
        string GetNextLocalizacao();
        Task<DataTableServerSideResult<LivroViewModel>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
        Int64 GetTotalAtivos();
        Int64 GetTotalInativos();
        Int64 GetTotalDisponiveis();
        Int64 GetTotalIndisponiveis();
        Task<ValidationResult> ColocarEstanteAsync(ColocarEstanteRequestViewModel 
                                                colocarEstanteRequestViewModel);
        Int64 GetTotalWithIgnoreQueryFilter();
        IEnumerable<LivroViewModel> GetAllDisponiveis(int ipen);
        Int64 GetLocalizacao(Guid id);
        ValidationResult GetAllDisponiveisNaoLidosByIpenAndGenero(LivrosParaEdicaoRequestViewModel
                                                                    livrosParaEdicaoRequestViewModel);
    }
}
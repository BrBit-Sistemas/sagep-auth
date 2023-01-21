using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Forms;
using Sagep.Application.ViewModels.Oficios.Educacao;
using Sagep.Application.ViewModels.Relatorios;
using Sagep.Application.ViewModels.Requests;
using Sagep.Application.ViewModels.Responses;
using Sagep.Domain.Enums;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IAlunoLeituraAppService : IDisposable
    {
        Task<OficioEducacaoLeituraViewModel> GetOficioLeituraAsync(List<string> leiturasIds);
        Task<Guid> GetCronogramaIdAsync(Guid alunoLeituraId);
        Task<DataTableServerSideResult<AlunoLeituraViewModel>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
        Task<FormularioLeituraFormModel> GetAllForFormsLeituraAsync(AlunoLeituraFormsLeiturasRequestModel alunoLeituraFormsLeiturasRequestModel);
        Task<RelatorioAvaliacaoViewModel> GetAllForRelAvaliacaoAsync(AlunoLeituraRelAvaliacaoRequestModel alunoLeituraRelAvaliacaoRequestModel);
        Task<ValidationResult> AddAsync(AlunoLeituraViewModel alunoLeituraViewModel);
        Task<AlunoLeituraNovosResponseViewModel> AddsAsync(AlunoLeituraNovosRequestViewModel 
                                                           alunoLeituraNovosRequestViewModel);
        Task<ValidationResult> UpdateAsync(AlunoLeituraViewModel alunoLeituraViewModel);
        ValidationResult Avaliar(AlunoLeituraViewModel alunoLeituraViewModel);
        ValidationResult Remove(Guid id);
        IEnumerable<AlunoLeituraViewModel> GetAllWithInclude();
        Task<IEnumerable<AlunoLeituraViewModel>> GetAllAsync();
        Task<AlunoLeituraViewModel> GetByIdAsync(string id);
        AlunoLeituraViewModel GetByIdIncludes(string id);
        Int64 GetTotalAtivos();
        Int64 GetTotalInativos();
        Int64 GetTotalWithIgnoreQueryFilter();
        Task<AlunoLeituraViewModel> GetByChaveLeituraAsync(string chaveLeitura);
        ValidationResult GetLivroForEdicao(string alunoLeituraId);
        Task<Int64> GetTotalByAvaliacaoConceitoAsync(AlunoLeituraAvaliacaoConceitoEnum avlC);
        Task<Int64> GetTotalByLeituraTipoAsync(LeituraTipoEnum lt);
    }
}
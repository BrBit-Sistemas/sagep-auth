using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Application.ViewModels.Reports;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Application.Interfaces
{
    public interface IAlunoEjaAppService : IDisposable
    {
        Task<ValidationResult> AddAsync(AlunoEjaViewModel alunoEjaViewModel);
        ValidationResult Update(AlunoEjaViewModel alunoEjaViewModel);
        ValidationResult UpdateWithoutCommitFromEdiDetentos(Guid id);
        ValidationResult Remove(Guid id);
        Task<Int64> GetTotalByFaseStatusAsync(AlunoEjaFaseStatusEnum faseStatus);
        Task<Int64> GetTotalInativosAsync();
        Task<Int64> GetTotalByCursoAsync(CursoEnum curso);
        Task<Int64> GetTotalByTurnoPeriodoAsync(TurnoEnum turnoPeriodo);        
    }
}
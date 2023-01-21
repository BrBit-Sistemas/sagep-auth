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
    public interface IAlunoAppService : IDisposable
    {
        Task<string> GetNomeAsync(string id);
        Task<IEnumerable<AlunoViewModel>> GetAllAsync();
        ValidationResult Add(AlunoViewModel alunoViewModel);
        ValidationResult Update(AlunoViewModel alunoViewModel);
        ValidationResult Remove(Guid id);
        AlunoViewModel GetByDetentoIpen(int ipen);
        Int64 GetTotalAtivos();
        Int64 GetTotalByEscolaridade(EscolaridadeEnum escolaridade);
        Task<bool> ActivateOrDeactivateAsync (string id);
    }
}
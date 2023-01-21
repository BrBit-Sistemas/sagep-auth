using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;

namespace Sagep.Domain.Interfaces
{
    public interface IAlunoRepository : IRepository<Aluno>
    {
        Task<string> GetNomeAsync(Guid id);
        Task<IEnumerable<Aluno>> GetAllAsync(Guid tenantId);
        Aluno GetByDetentoIpen(int ipen);
        IEnumerable<Aluno> GetAllWithIncludes();
        Aluno GetByIdWithIncludes(Guid id);
        Int64 GetTotalAtivos();
        Int64 GetTotalByEscolaridade(EscolaridadeEnum escolaridade);
        Task<Aluno> GetAsync(int ipen);
        Task<Aluno> GetAtivoInativoAsync(Guid id);
    }
}
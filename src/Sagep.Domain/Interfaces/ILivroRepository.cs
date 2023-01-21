using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Models;
using System.Numerics;
using Sagep.Domain.Models.DataTable;

namespace Sagep.Domain.Interfaces
{
    public interface ILivroRepository : IRepository<Livro>
    {
        Task<IEnumerable<Livro>> GetAllAsync(Guid tenantId);
        BigInteger GetNextLocalizacao();
        Task<DataTableServerSideResult<Livro>> GetWithDataTableResultAsync(DataTableServerSideRequest request);
        Task<bool> AlreadyLocalizacaoAsync(Guid tenantId, Int64 localizacao, Guid? Id);
        Int64 GetTotalInativos();
        Int64 GetTotalAtivos();
        Int64 GetTotalDisponiveis();
        Int64 GetTotalIndisponiveis();
        Task<Livro> GetByLocalizacaoAsync(Guid tenantId, Int64 localizacao);
        Int64 GetTotalWithIgnoreQueryFilter();
        Livro GetAtivoInativoById(Guid id);
        Task<IEnumerable<Livro>> GetAllAtivoInativoAsync(Guid tenantId);
        Livro GetOneTituloDisponivelRemovingList(IEnumerable<Livro> leitorTitulosLidos,
                                        string generoNome);
        Livro GetOneTituloDisponivel(string generoNome);
        IEnumerable<Livro> GetAllDisponiveis();
        IEnumerable<Livro> GetAllDisponiveis(string livroGeneroNome);
        Int64 GetLocalizacao(Guid id);
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Sagep.Application.ViewModels;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;

namespace Sagep.Application.Interfaces
{
    public interface IContaCorrenteAppService : IDisposable
    {
        IEnumerable<ContaCorrenteViewModel> GetAll();
        IEnumerable<ContaCorrenteViewModel> GetAllByTipos(List<ContaCorrenteTipoEnum> tipos);
        Task<IEnumerable<ContaCorrenteViewModel>> GetAllAsync();
        decimal GetSaldoByColaboradorId(Guid colaboradorId);
        decimal GetSaldoByColaboradorNome(string colaboradorNome);
        ContaCorrenteViewModel GetByColaboradorNomeWithInclude(string colaboradorNome);
        bool AlreadyByColaboradorId(Guid id);
        ValidationResult Add(ContaCorrenteViewModel contaCorrenteViewModel);
        ValidationResult Update(ContaCorrenteViewModel contaCorrenteViewModel);
        ValidationResult Remove(Guid id);
        bool NumeroAlready(int numero);
        ContaCorrenteViewModel GetByColaboradorNome(string colaboradorNome);
        IEnumerable<ContaCorrenteViewModel> GetAllForFC();
        decimal GetSaldoSemLCTOByColaboradorNome(string lancamentoId, string colaboradorNome);
        decimal GetSaldoSemLCTOByEmpresaRazaoSocialAndTipo(string lancamentoId, 
                                                            string empresaRazaoSocial, 
                                                            bool isTipoCofre);
    }
}
using Sagep.Domain.Interfaces;
using Sagep.Domain.Models;
using Sagep.Infra.Data.Context;

namespace Sagep.Infra.Data.Repository
{
    public class ColaboradorPontoApontamentoRepository : Repository<ColaboradorPontoApontamento>, IColaboradorPontoApontamentoRepository
    {
        public ColaboradorPontoApontamentoRepository(SigespDbContext context) 
            :base(context) 
        {
        }

        
    }
}
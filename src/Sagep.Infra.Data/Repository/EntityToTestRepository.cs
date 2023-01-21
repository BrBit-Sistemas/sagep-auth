using System.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sagep.Domain.Interfaces;
using Sagep.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Domain.Models.DataTable;
using Sagep.Infra.Data.Extensions;
using Sagep.Infra.Data.Extensions.DataTable;

namespace Sagep.Infra.Data.Repository
{
    public class EntityToTestRepository : Repository<Detento>, IEntityToTestRepository
    {
        public EntityToTestRepository(SigespDbContext context)
            : base(context)
        {
            
        }

        public new bool Add (Detento detento)
        {
            DbSet.Add(detento);
            return false;
        }
    }
}
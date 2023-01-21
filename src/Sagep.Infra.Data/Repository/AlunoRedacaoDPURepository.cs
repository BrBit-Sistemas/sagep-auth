using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Xml;
using System.Security.AccessControl;
using Microsoft.VisualBasic.CompilerServices;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Data;
using System.Diagnostics;
using System.Data.Common;
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
using Sagep.Infra.Data.Extensions.DataTable;

namespace Sagep.Infra.Data.Repository
{
    public class AlunoRedacaoDPURepository : Repository<AlunoRedacaoDPU>, IAlunoRedacaoDPURepository
    {
        public AlunoRedacaoDPURepository(SigespDbContext context)
            : base(context)
        {
        }
    }
}
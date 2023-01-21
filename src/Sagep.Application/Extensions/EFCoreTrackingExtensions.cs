using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sagep.Infra.Data.Context;

namespace Sagep.Application.Extensions
{
    public static class EFCoreTrackingExtensions
    {
        // public static void DetachLocal<T>(this SigespDbContext context, T t, string entryId) where T : class
        // {
        //     var local = context.Set<(e => EF.Property<bool>("IsDeleted")>()
        //                                 .Local
        //                                 .FirstOrDefault(entry => entry.Id.Equals(entryId));
        //     // check if local is not null 
        //     if (local != null)
        //     {
        //         // detach
        //         context.Entry(local).State = EntityState.Detached;
        //     }
        //     // set Modified flag in your entry
        //     context.Entry(t).State = EntityState.Modified;
        // }
    }
}
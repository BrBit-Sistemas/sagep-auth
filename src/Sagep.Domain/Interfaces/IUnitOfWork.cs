using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;

namespace Sagep.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        ValidationResult CommitVR();
        Task<ValidationResult> CommitAsyncVR();
        Task<int> CommitAsync();
        int CommitWithoutSoftDeletion();
    }
}

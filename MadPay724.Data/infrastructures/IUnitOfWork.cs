using System;
using System.Threading.Tasks;
using MadPay724.Data.Repositories.Interfaces;
using MadPay724.Data.Repositories.Repos;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.infrastructures
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        IUserRepository UserRepository { get; }
        void Save();
        Task<int> SaveAsync();
    }

}

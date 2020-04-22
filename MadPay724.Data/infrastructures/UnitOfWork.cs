using System;
using System.Threading.Tasks;
using MadPay724.Data.Repositories.Interfaces;
using MadPay724.Data.Repositories.Repos;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.infrastructures
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext ,new()
    {
        #region ctor
        protected readonly DbContext _db;
        public UnitOfWork()
        {
            _db = new TContext();
        }
        #endregion
        #region privaterepository
        private IUserRepository userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(_db);
                }
                return userRepository;
            }
        }
        #endregion


        #region save
        public void Save()
        {
            _db.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            return _db.SaveChangesAsync();
        }
        #endregion
        #region Dispose
        private bool Disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!Disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                
            }
            Disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}

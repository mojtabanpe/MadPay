using System;
using MadPay724.Data.DatabaseContext;
using MadPay724.Data.infrastructures;
using MadPay724.Data.Models;
using MadPay724.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.Repositories.Repos
{
        public class UserRepository : Repository<User>, IUserRepository
        {
            private readonly DbContext _db;
            public UserRepository(DbContext dbContext) : base(dbContext)
            {
                _db = (_db ?? (MadPayDBContext)_db);
            }
        }
}

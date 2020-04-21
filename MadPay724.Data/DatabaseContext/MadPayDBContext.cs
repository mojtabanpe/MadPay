using System;
using MadPay724.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MadPay724.Data.DatabaseContext
{
    public class MadPayDBContext : DbContext
    {
        public MadPayDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; initial catalog = MadPay; user id = sa; password = reallyStrongPwd123; ");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<BankCard> BankCards { get; set; }

    }
}

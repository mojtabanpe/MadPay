using System;
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
            optionsBuilder.UseSqlServer("dataource= local; initialcatalog = MadPay; integrated security = true; multipleactiveresultsets = true");
        }
    }
}

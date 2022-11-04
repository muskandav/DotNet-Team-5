using AccountService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountService.Database
{
    public class AccountDBContext: DbContext
    {
        public DbSet<Account> accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Data Source=MUSKAN\SQLEXPRESS;Initial Catalog=Bank;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=MUSKAN\ABC;Password=muskanpandey");

        }
    }
}

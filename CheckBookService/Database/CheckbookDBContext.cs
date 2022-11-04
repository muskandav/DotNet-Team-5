
using CheckBookService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CheckBookService.Database
{
    public class CheckbookDBContext:DbContext
    {
        //Entity set
        public DbSet<Checkbook> Checkbooks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Data Source=MUSKAN\SQLEXPRESS;Initial Catalog=Bank;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=MUSKAN\ABC;Password=muskanpandey");

        }
    }
}

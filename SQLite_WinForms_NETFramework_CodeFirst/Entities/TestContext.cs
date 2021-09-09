using Microsoft.EntityFrameworkCore;

namespace SQLite_WinForms_NETFramework_CodeFirst.Entities
{
    public class TestContext : DbContext
    {
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<CashVoucher> CashVouchers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=TestDb.sqlite");
        }
    }
}
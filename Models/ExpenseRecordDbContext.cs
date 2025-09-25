using Microsoft.EntityFrameworkCore;

namespace ExpenseRecord.Models
{
    public class ExpenseRecordDbContext : DbContext
    {

        public ExpenseRecordDbContext(DbContextOptions<ExpenseRecordDbContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expenses { get; set; }
    }
}

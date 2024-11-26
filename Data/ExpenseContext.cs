using Andrei_Corpodean_Lab5.Models;
using Microsoft.EntityFrameworkCore;
namespace Andrei_Corpodean_Lab5.Data
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }

    }
}
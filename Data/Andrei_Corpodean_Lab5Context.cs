using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Andrei_Corpodean_Lab5.Models;

namespace Andrei_Corpodean_Lab5.Data
{
    public class Andrei_Corpodean_Lab5Context : DbContext
    {
        public Andrei_Corpodean_Lab5Context (DbContextOptions<Andrei_Corpodean_Lab5Context> options) : base(options)
        {
        }

        public DbSet<Expense> Expense { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyKoloAPI.Models;

namespace MyKoloAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Dbset to represent tables
        //Dbset<T>
        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Savings> Savings { get; set; }

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
    }
}

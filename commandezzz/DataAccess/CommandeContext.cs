using System;
using commandezzz.Model;
using Microsoft.EntityFrameworkCore;

namespace commandezzz.DataAccess
{
    public class CommandeContext : DbContext
    {
        public CommandeContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}

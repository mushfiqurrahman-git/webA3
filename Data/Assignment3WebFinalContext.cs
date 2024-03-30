using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3WebFinal.Models;

namespace Assignment3WebFinal.Data
{
    public class Assignment3WebFinalContext : DbContext
    {
        public Assignment3WebFinalContext (DbContextOptions<Assignment3WebFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment3WebFinal.Models.Cart> Cart { get; set; } = default!;
        public DbSet<Assignment3WebFinal.Models.Comment> Comment { get; set; } = default!;
        public DbSet<Assignment3WebFinal.Models.Order> Order { get; set; } = default!;
        public DbSet<Assignment3WebFinal.Models.Product> Product { get; set; } = default!;
        public DbSet<Assignment3WebFinal.Models.User> User { get; set; } = default!;
    }
}

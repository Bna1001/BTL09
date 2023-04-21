using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using baitaplonnhom09.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<baitaplonnhom09.Models.Ceo> Ceo { get; set; } = default!;

        public DbSet<baitaplonnhom09.Models.Sale> Sale { get; set; } = default!;

        public DbSet<baitaplonnhom09.Models.Staff> Staff { get; set; } = default!;

        public DbSet<baitaplonnhom09.Models.Account> Account { get; set; } = default!;
    }

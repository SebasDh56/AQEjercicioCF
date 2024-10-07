using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AQEjercicioCF.Models;

    public class AQEjercicioCFContext : DbContext
    {
        public AQEjercicioCFContext (DbContextOptions<AQEjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<AQEjercicioCF.Models.Burger> Burger { get; set; } = default!;
    }

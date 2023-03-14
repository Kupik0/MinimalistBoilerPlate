using WebApi.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApi;

    public class MinimalistBoilerPlateDbContext : DbContext
    { 
        public MinimalistBoilerPlateDbContext(DbContextOptions<MinimalistBoilerPlateDbContext> options) : base(options)
        {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connStr = "User ID=postgres; Password=mysecretpassword; Server=localhost; Port=5432; Database=minimalboilerplate;Pooling=true;Include Error Detail=true; ";
            optionsBuilder.UseNpgsql(connStr, opt =>
            {
                opt.EnableRetryOnFailure();
            });
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    }

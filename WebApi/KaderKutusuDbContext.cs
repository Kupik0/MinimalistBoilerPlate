using WebApi.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApi;

    public class KaderKutusuDbContext : DbContext
    { 
        public KaderKutusuDbContext(DbContextOptions<KaderKutusuDbContext> options) : base(options)
        {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public DbSet<KaderKutusu> KaderKutusu { get; set; }
    public DbSet<Kutu> Kutu { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Sepet> Sepet { get; set; }
    public DbSet<DogalTas> DogalTas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connStr = "User ID=postgres; Password=mysecretpassword; Server=localhost; Port=5432; Database=kaderkutusu;Pooling=true;Include Error Detail=true; ";
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

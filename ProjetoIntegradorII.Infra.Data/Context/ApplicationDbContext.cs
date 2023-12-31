﻿using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorII.Domain.Entities;

namespace ProjetoIntegradorII.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Beneficiary> Beneficaries { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}

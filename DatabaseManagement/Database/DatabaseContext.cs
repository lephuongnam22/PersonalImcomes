using System;
using DatabaseManagement.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseManagement.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public virtual DbSet<Stock> Stocks { get; set; }

        public virtual DbSet<Expense> Expenses { get; set; }

        public virtual DbSet<Income> Incomes { get; set; }

        public virtual DbSet<CashTransacstion> CashTransacstions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Income>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("now()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("now()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("now()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<CashTransacstion>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("now()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("now()");
            });
        }
    }
}

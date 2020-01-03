using System;
using DatabaseManagement.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using PersonalIncomeStatement.Models.DomainModels;

namespace PersonalIncomeStatement.Database
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
                    .HasDefaultValueSql("getdate()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("getdate()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("getdate()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<CashTransacstion>(entity =>
            {
                entity.Property(p => p.CreatedAt)
                    .HasDefaultValueSql("getdate()");

                entity.Property(p => p.UpdatedAt)
                    .HasDefaultValueSql("getdate()");
            });
        }
    }
}

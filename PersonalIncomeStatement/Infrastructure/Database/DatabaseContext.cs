using Microsoft.EntityFrameworkCore;
using PersonalIncomeStatement.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalIncomeStatement.Infrastructure.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public virtual DbSet<Stock> Stocks { get; set; }
    }
}

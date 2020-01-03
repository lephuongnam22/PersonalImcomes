using System;

namespace PersonalIncomeStatement.Models.DomainModels
{
    public class CashTransacstion
    { 
        public int Id { get; set; }
        public decimal Money { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

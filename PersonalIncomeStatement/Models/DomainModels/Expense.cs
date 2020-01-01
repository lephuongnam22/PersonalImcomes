using PersonalIncomeStatement.Models.Enums;
using System;

namespace PersonalIncomeStatement.Models.DomainModels
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ExpenseType Type { get; set; }

        public decimal Money { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}

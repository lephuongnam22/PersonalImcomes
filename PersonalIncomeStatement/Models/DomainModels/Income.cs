using System;

namespace PersonalIncomeStatement.Models.DomainModels
{
    public class Income
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Money { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }


    }
}

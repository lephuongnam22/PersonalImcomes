using System;

namespace DatabaseManagement.Models
{
    public class CashTransacstion
    { 
        public int Id { get; set; }
        public int Money { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

using System;
using DatabaseManagement.Enums;

namespace ServiceManagement.DTOs
{
    public class ExpenseModel
    {
        public string Description { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public int Money { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}

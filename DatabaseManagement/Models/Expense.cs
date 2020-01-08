using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DatabaseManagement.Enums;

namespace DatabaseManagement.Models
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public int Money { get; set; }
        public DateTime ExpenseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

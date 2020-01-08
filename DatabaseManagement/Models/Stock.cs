using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DatabaseManagement.Enums;

namespace DatabaseManagement.Models
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public TradingType Type { get; set; }
        public decimal Money { get; set; }
        public decimal TradingFee { get; set; }
        public decimal IncomingFee { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

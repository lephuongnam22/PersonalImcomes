using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DatabaseManagement.Models.Enums;

namespace DatabaseManagement.Models.DomainModels
{
    public class TradingHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Reason { get; set; }
        public int Ammount { get; set; }
        public int Money { get; set; }
        public TradingType TradingType { get; set; }
        public int TradingFee { get; set; }
        public int IncomingFee { get; set; }
        public DateTime TradingDate { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}

using System;
using PersonalIncomeStatement.Models.Enums;

namespace PersonalIncomeStatement.Models.DTOs
{
    public class StockModel
    {
        public int Id { get; set; }
        public TradingType TradingType { get; set; }
        public decimal Money { get; set; }
        public decimal TradingFee { get; set; }
        public decimal IncomingFee { get; set; }
    }
}

using System;
using DatabaseManagement.Enums;

namespace ServiceManagement.DTOs
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

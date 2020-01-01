using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalIncomeStatement.Models.DomainModels
{
    public class Stock
    {
        public int Id { get; set; }
        public int Type { get; set; }

        public decimal Money { get; set; }

        public decimal TradingFee { get; set; }

        public decimal IncomingFee { get; set; }

    }
}

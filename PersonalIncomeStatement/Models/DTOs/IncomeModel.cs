﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalIncomeStatement.Models.DTOs
{
    public class IncomeModel
    {
        public decimal Money { get; set; }
        public string Description { get; set; }

        public DateTime ReceiveDate { get; set; }
    }
}

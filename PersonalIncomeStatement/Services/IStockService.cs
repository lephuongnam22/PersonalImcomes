using System;
using System.Threading.Tasks;
using PersonalIncomeStatement.Models.DTOs;

namespace PersonalIncomeStatement.Services
{
    public interface IStockService
    {
        Task<int> AddStockAsync(StockModel stock);
    }
}

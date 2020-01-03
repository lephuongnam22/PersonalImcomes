using System;
using System.Threading.Tasks;
using DatabaseManagement.Models.DTOs;

namespace DatabaseManagement.Services
{
    public interface IStockService
    {
        Task<int> AddStockAsync(StockModel stock);
    }
}

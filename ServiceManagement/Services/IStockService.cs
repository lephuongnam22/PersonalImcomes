using System;
using System.Threading.Tasks;
using ServiceManagement.DTOs;

namespace ServiceManagement.Services
{
    public interface IStockService
    {
        Task<int> AddStockAsync(StockModel stock);
    }
}

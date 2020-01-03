using System;
using System.Threading.Tasks;
using DatabaseManagement.Models.DomainModels;
using DatabaseManagement.Models.DTOs;
using DatabaseManagement.Repositories;

namespace DatabaseManagement.Services
{
    public class StockService : IStockService
    {
        private readonly IRepositoryManager _repositoryManager;

        public StockService(IRepositoryManager repositoryManager)
        {
            this._repositoryManager = repositoryManager;
        }

        public async Task<int> AddStockAsync(StockModel stockModel)
        {
            var stock = this.MapStockModelToStock(stockModel);
            await this._repositoryManager.StockRepository.AddStockRecordAsync(stock);
            return await this._repositoryManager.SaveChanges();
        }

        private Stock MapStockModelToStock(StockModel stockModel)
        {
            return new Stock
            {
                Money = stockModel.Money,
                Type = stockModel.TradingType,
                IncomingFee = stockModel.IncomingFee,
                TradingFee = stockModel.TradingFee
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseManagement.Models;
using DatabaseManagement.Repositories;
using ServiceManagement.DTOs;

namespace ServiceManagement.Services
{
    public class StockService : IStockService
    {
        private readonly IRepositoryManager _repositoryManager;

        public StockService(IRepositoryManager repositoryManager)
        {
            this._repositoryManager = repositoryManager;
        }

        public async Task<IList<StockModel>> GetAllAsync()
        {
            var stocks = await this._repositoryManager.StockRepository.GetAllAsync();
            return stocks.Select(n => MapFromStockToStockModel(n)).ToList();
        }

        public async Task<int> AddStockAsync(StockModel stockModel)
        {
            var stock = this.MapStockModelToStock(stockModel);
            await this._repositoryManager.StockRepository.AddStockRecordAsync(stock);
            await this._repositoryManager.TradingHistoryRepository.AddAsync(new TradingHistory { });
            return await this._repositoryManager.SaveChanges();
        }

        private StockModel MapFromStockToStockModel(Stock stock)
        {
            return new StockModel
            {
            };
        }

        private Stock MapStockModelToStock(StockModel stockModel)
        {
            return new Stock
            {
                //Money = stockModel.Money,
                //Type = stockModel.TradingType,
                //IncomingFee = stockModel.IncomingFee,
                //TradingFee = stockModel.TradingFee
            };
        }
    }
}

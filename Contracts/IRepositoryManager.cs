﻿using System.Threading.Tasks;
namespace Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IFridgeRepository Fridge { get; }
        IFridgeModelRepository FridgeModel { get; }
        IFridgeProductRepository FridgeProduct { get; }
        Task SaveAsync();
        Task StoredProcedureWithoutParamasAsync(string name);
    }

}

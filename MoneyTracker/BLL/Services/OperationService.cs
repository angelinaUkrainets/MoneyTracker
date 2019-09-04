using BLL.Interfaces;
using BLL.Models;
using DLL.Entities;
using DLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OperationService : IOperationService
    {
        private readonly EFContext context = new EFContext();
        private readonly IMoneyTrackerRepository<Operation> repository;
        public OperationService()
        {
            repository = new OperationRepository(context);
        }
        public int AddOperation(OperationAddModel operation)
        {
            try
            {
                int result = -1;
                Operation newOperation = new Operation() { Summ = operation.Summ, CategoryId = operation.CategoryId, IsProfit = operation.IsProfit, WayOfPayId = operation.WayOfPayId};
                repository.Add(newOperation);
                result = 1;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

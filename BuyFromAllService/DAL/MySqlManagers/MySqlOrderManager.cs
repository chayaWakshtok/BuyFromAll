using Entities.DataManagers;
using Entities.Retail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.DataManagers.IDataManager;

namespace DAL.MySqlManagers
{
    public class MySqlOrderManager : IOrderManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public OrderEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(OrderEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(OrderEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

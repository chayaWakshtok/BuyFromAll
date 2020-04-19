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
    public class MySqlOrderItemManager : IOrderItemManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public OrderItemEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderItemEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(OrderItemEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(OrderItemEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class MySqlCustomerManager : ICustomerManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public ColorEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<ColorEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<ColorEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(ColorEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(ColorEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

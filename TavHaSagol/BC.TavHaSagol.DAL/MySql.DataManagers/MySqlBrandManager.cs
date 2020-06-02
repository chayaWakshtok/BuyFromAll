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
    public class MySqlBrandManager : IBrandManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public BrandEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<BrandEntity>> GetAllEntityAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<BrandEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<BrandEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(BrandEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(BrandEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

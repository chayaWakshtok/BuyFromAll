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
    public class MySqlSizeManager : ISizeManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public SizeEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<SizeEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<SizeEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(SizeEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(SizeEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

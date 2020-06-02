
using AM.Common.Data;
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
    public class MySqIFeatureManager : IFeatureManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public FeatureEntity FillEntity(DataRow row, AM.Common.Data.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public FeatureEntity FillEntity(DataRow row, Entities.DataManagers.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeatureEntity>> GetAllEntityAsync(AM.Common.Data.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeatureEntity>> GetEntitiesAsync(AM.Common.Data.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeatureEntity>> GetEntitiesAsync(Entities.DataManagers.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeatureEntity> GetEntityAsync(int key, AM.Common.Data.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<FeatureEntity> GetEntityAsync(int key, Entities.DataManagers.Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(FeatureEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(FeatureEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

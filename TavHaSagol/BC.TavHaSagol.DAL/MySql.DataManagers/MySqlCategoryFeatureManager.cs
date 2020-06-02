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
    public class MySqlCategoryFeatureManager : ICategoryFeatureManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public CategoryFeatureEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryFeatureEntity>> GetAllEntityAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryFeatureEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryFeatureEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(CategoryFeatureEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(CategoryFeatureEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

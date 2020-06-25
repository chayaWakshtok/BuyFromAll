using AM.Tools.Connectivity;
using Entities.DataManagers;
using Entities.Retail;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.DataManagers.IDataManager;

namespace DAL.MySqlManagers
{
    public class MySqlCategoryFeatureManager : ICategoryFeatureManager
    {
        #region Members

        private CommonDbContext _dbContext;
        #endregion

        #region CTOR

        public MySqlCategoryFeatureManager()
        {
            _dbContext = new CommonDbContext();
        }
        #endregion
        public async Task<int> DeleteEntityAsync(int key)
        {
            return await _dbContext.DeleteAsync(DbContent.Tables.CategoryFeatures.Delete, new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.CategoryFeatures.Id.Name}", key)
            });
        }

        public CategoryFeatureEntity FillEntity(DataRow row, Includes includes = null)
        {
            if (row == null)
                return null;

            CategoryFeatureEntity entity = new CategoryFeatureEntity()
            {
                Id = DataRowHelper.GetValue<int>(row, DbContent.Tables.CategoryFeatures.Id.FullName, DbContent.Tables.CategoryFeatures.Id.Name),
                CategoryId= DataRowHelper.GetValue<int>(row, DbContent.Tables.CategoryFeatures.CategoryId.FullName, DbContent.Tables.CategoryFeatures.CategoryId.Name),
                FeatureId= DataRowHelper.GetValue<int>(row, DbContent.Tables.CategoryFeatures.FeatureId.FullName, DbContent.Tables.CategoryFeatures.FeatureId.Name),

            };
            return entity;
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

        public async Task<int> SaveEntityAsync(CategoryFeatureEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.CategoryFeatures.CategoryId.Name}", entity.CategoryId),
                new MySqlParameter($"@{DbContent.Tables.CategoryFeatures.FeatureId.Name}", entity.FeatureId),

            };

            entity.Id = await _dbContext.InsertAsync(DbContent.Tables.CategoryFeatures.InsertTable, true, parameters);
            return entity.Id;
        }

        public async Task<int> UpdateEntityAsync(CategoryFeatureEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.CategoryFeatures.Id.Name}", entity.Id),
                new MySqlParameter($"@{DbContent.Tables.CategoryFeatures.CategoryId.Name}", entity.CategoryId),
                new MySqlParameter($"@{DbContent.Tables.CategoryFeatures.FeatureId.Name}", entity.FeatureId),
            };

            return await _dbContext.UpdateAsync(DbContent.Tables.CategoryFeatures.UpdateTable, parameters);
        }
    }
}

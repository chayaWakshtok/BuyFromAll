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
    public class MySqlCategoryManager : ICategoryManager
    {
        #region Members

        private CommonDbContext _dbContext;
        #endregion

        #region CTOR

        public MySqlCategoryManager()
        {
            _dbContext = new CommonDbContext();
        }
        #endregion
        public async Task<int> DeleteEntityAsync(int key)
        {
            return await _dbContext.DeleteAsync(DbContent.Tables.Categories.Delete, new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Categories.Id.Name}", key)
            });
        }

        public CategoryEntity FillEntity(DataRow row, Includes includes = null)
        {
            if (row == null)
                return null;

            CategoryEntity entity = new CategoryEntity()
            {
                Description = DataRowHelper.GetValue<string>(row, DbContent.Tables.Categories.Description.FullName, DbContent.Tables.Categories.Description.Name),
                Id = DataRowHelper.GetValue<int>(row, DbContent.Tables.Categories.Id.FullName, DbContent.Tables.Categories.Id.Name),
                Name = DataRowHelper.GetValue<string>(row, DbContent.Tables.Categories.Name.FullName, DbContent.Tables.Categories.Name.Name),
            };
            return entity;
        }


        public async Task<List<CategoryEntity>> GetEntitiesAsync(Includes includes = null)
        {
            string sql = $"select * from {DbContent.Tables.Categories.TableName}";

            DataTable dt = await _dbContext.GetDataTableAsync(sql, null);

            if (dt == null)
                return null;

            List<CategoryEntity> list = new List<CategoryEntity>(dt.Rows.Count);

            foreach (DataRow dr in dt.Rows)
                list.Add(FillEntity(dr));
            return list;
        }

        public Task<CategoryEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveEntityAsync(CategoryEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Categories.Name.Name}", entity.Name),
                new MySqlParameter($"@{DbContent.Tables.Categories.Description.Name}", entity.Description),

            };

            entity.Id = await _dbContext.InsertAsync(DbContent.Tables.Categories.InsertTable, true, parameters);
            return entity.Id;
        }

        public async Task<int> UpdateEntityAsync(CategoryEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Categories.Id.Name}", entity.Id),
                new MySqlParameter($"@{DbContent.Tables.Categories.Name.Name}", entity.Name),
                new MySqlParameter($"@{DbContent.Tables.Categories.Description.Name}", entity.Description),
            };

            return await _dbContext.UpdateAsync(DbContent.Tables.Categories.UpdateTable, parameters);
        }
    }
}

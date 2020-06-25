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
    public class MySqlBasketManager : IBasketManager
    {
        #region Members

        private CommonDbContext _dbContext;
        #endregion

        #region CTOR

        public MySqlBasketManager()
        {
            _dbContext = new CommonDbContext();
        }
        #endregion
        public async Task<int> DeleteEntityAsync(int key)
        {
            return await _dbContext.DeleteAsync(DbContent.Tables.Baskets.Delete, new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Baskets.Id.Name}", key)
            });
        }

        public BasketEntity FillEntity(DataRow row, Includes includes = null)
        {
            if (row == null)
                return null;

            BasketEntity entity = new BasketEntity()
            {
                Id = DataRowHelper.GetValue<int>(row, DbContent.Tables.Baskets.Id.FullName, DbContent.Tables.Baskets.Id.Name),
                Count= DataRowHelper.GetValue<int>(row, DbContent.Tables.Baskets.Count.FullName, DbContent.Tables.Baskets.Count.Name),
                ItemChildId= DataRowHelper.GetValue<int>(row, DbContent.Tables.Baskets.ItemChildId.FullName, DbContent.Tables.Baskets.ItemChildId.Name),
                UserId= DataRowHelper.GetValue<int>(row, DbContent.Tables.Baskets.UserId.FullName, DbContent.Tables.Baskets.UserId.Name),
            };
            return entity;
        }

        public Task<List<BasketEntity>> GetAllEntityAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<BasketEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<BasketEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveEntityAsync(BasketEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Baskets.UserId.Name}", entity.UserId),
                new MySqlParameter($"@{DbContent.Tables.Baskets.ItemChildId.Name}", entity.ItemChildId),
                new MySqlParameter($"@{DbContent.Tables.Baskets.Count.Name}", entity.Count),

            };

            entity.Id = await _dbContext.InsertAsync(DbContent.Tables.Baskets.InsertTable, true, parameters);
            return entity.Id;
        }

        public async Task<int> UpdateEntityAsync(BasketEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Baskets.Id.Name}", entity.Id),
                new MySqlParameter($"@{DbContent.Tables.Baskets.UserId.Name}", entity.UserId),
                new MySqlParameter($"@{DbContent.Tables.Baskets.ItemChildId.Name}", entity.ItemChildId),
                new MySqlParameter($"@{DbContent.Tables.Baskets.Count.Name}", entity.Count),
            };

            return await _dbContext.UpdateAsync(DbContent.Tables.Baskets.UpdateTable, parameters);
        }
    }
}

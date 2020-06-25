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
    public class MySqlBrandManager : IBrandManager
    {
        #region Members

        private CommonDbContext _dbContext;
        #endregion

        #region CTOR

        public MySqlBrandManager()
        {
            _dbContext = new CommonDbContext();
        }
        #endregion
        public async Task<int> DeleteEntityAsync(int key)
        {
            return await _dbContext.DeleteAsync(DbContent.Tables.Brands.Delete, new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Brands.Id.Name}", key)
            });
        }

        public BrandEntity FillEntity(DataRow row, Includes includes = null)
        {
            if (row == null)
                return null;

            BrandEntity entity = new BrandEntity()
            {
                Id = DataRowHelper.GetValue<int>(row, DbContent.Tables.Brands.Id.FullName, DbContent.Tables.Brands.Id.Name),
                Description= DataRowHelper.GetValue<string>(row, DbContent.Tables.Brands.Description.FullName, DbContent.Tables.Brands.Description.Name),
                Name= DataRowHelper.GetValue<string>(row, DbContent.Tables.Brands.Name.FullName, DbContent.Tables.Brands.Name.Name),
            };
            return entity;
        }

        public async Task<List<BrandEntity>> GetEntitiesAsync(Includes includes = null)
        {
            string sql = $"select * from {DbContent.Tables.Brands.TableName}";

            DataTable dt = await _dbContext.GetDataTableAsync(sql, null);

            if (dt == null)
                return null;

            List<BrandEntity> list = new List<BrandEntity>(dt.Rows.Count);

            foreach (DataRow dr in dt.Rows)
                list.Add(FillEntity(dr));
            return list;
        }

        public Task<BrandEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveEntityAsync(BrandEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Brands.Name.Name}", entity.Name),
                new MySqlParameter($"@{DbContent.Tables.Brands.Description.Name}", entity.Description),

            };

            entity.Id = await _dbContext.InsertAsync(DbContent.Tables.Brands.InsertTable, true, parameters);
            return entity.Id;
        }

        public async Task<int> UpdateEntityAsync(BrandEntity entity)
        {
            IList<DbParameter> parameters = new List<DbParameter>()
            {
                new MySqlParameter($"@{DbContent.Tables.Brands.Id.Name}", entity.Id),
                new MySqlParameter($"@{DbContent.Tables.Brands.Name.Name}", entity.Name),
                new MySqlParameter($"@{DbContent.Tables.Brands.Description.Name}", entity.Description),
            };

            return await _dbContext.UpdateAsync(DbContent.Tables.Brands.UpdateTable, parameters);
        }
    }
}

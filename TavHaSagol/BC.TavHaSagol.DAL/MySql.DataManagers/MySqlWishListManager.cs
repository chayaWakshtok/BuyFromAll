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
    public class MySqlWishListManager : IWishListManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public WishListEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<WishListEntity>> GetAllEntityAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<WishListEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<WishListEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(WishListEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(WishListEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

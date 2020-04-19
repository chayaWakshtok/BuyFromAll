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
    public class MySqlCityManager : ICityManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public CityEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<CityEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<CityEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(CityEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(CityEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

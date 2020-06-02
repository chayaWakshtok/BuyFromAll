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
    class MySqlMaterialManager : IMaterialManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public MaterialEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<MaterialEntity>> GetAllEntityAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<MaterialEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<MaterialEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(MaterialEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(MaterialEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

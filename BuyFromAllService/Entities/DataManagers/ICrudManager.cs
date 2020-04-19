using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entities.DataManagers
{
    public interface ICrudManager<ObjectType, KeyType>
    {
        Task<int> DeleteEntityAsync(KeyType key);
        ObjectType FillEntity(DataRow row, Includes includes = null);
        Task<ObjectType> GetEntityAsync(KeyType key, Includes includes = null);
        Task<List<ObjectType>> GetEntitiesAsync( Includes includes = null);
        Task<int> SaveEntityAsync(ObjectType entity);
        Task<int> UpdateEntityAsync(ObjectType entity);
    }
}

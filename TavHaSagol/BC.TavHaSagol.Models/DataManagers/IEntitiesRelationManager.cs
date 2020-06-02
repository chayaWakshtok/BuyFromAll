using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataManagers
{
    public interface IEntitiesRelationManager<EntityType, RelatedEntityType, EntityKeyType, RelatedEntityKeyType>
    {
        Task<int> AddRelationAsync(EntityType parentEntity, RelatedEntityType listedEntity);
        Task<int> DeleteRelationAsync(EntityKeyType parentEntityKey, RelatedEntityKeyType listedEntityKey);
        Task<IList<RelatedEntityType>> GetRelatedEntitiesAsync(EntityKeyType parentEntityKey, int start = 0, int count = 100, Includes includes = null);
    }
}

using AM.Common;
using AM.Common.BL;
using Entities.DataManagers;
using Entities.Retail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.DataManagers.IDataManager;

namespace BL
{
    public class Category : IBaseCrud<CategoryEntity, int>
    {
        private ICategoryManager _categoryManager;
        public Category(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public Task<ActionResult<CategoryEntity>> DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<List<CategoryEntity>>> GetAll()
        {
            try
            {
                List<CategoryEntity> list = await _categoryManager.GetEntitiesAsync();
                return new ActionResult<List<CategoryEntity>>(ActionStatus.Ok, list);
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.GetEntityException(typeof(CategoryEntity));
                //_loggerManager.Error(errMessage, ex);
                return new ActionResult<List<CategoryEntity>>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }

        public Task<ActionResult<CategoryEntity>> SaveAsync(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<CategoryEntity>> UpdateAsync(CategoryEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<CategoryEntity>> FindAsync(int key, AM.Common.Data.Includes includes = null)
        {
            throw new NotImplementedException();
        }
    }
}

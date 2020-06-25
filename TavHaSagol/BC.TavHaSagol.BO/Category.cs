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
        public async Task<ActionResult<CategoryEntity>> DeleteAsync(int key)
        {
            try
            {
                if (key <= 0)
                    throw new ArgumentException("Given key should be greater than zero");
                ActionResult<CategoryEntity> result = new ActionResult<CategoryEntity>(ActionStatus.Ok);

                int res = await _categoryManager.DeleteEntityAsync(key);
                if (res <= 0)
                    result.SetError().AddExceptionMessage($"Unable to delete category id: {key}");
                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.DeleteEntityException(typeof(CategoryEntity), key.ToString());
                return new ActionResult<CategoryEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
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

        public async Task<ActionResult<CategoryEntity>> SaveAsync(CategoryEntity entity)
        {
            try
            {
                if (entity.Id == 0)
                    throw new ArgumentException("Only entity with id can be saved");

                ActionResult<CategoryEntity> result = new ActionResult<CategoryEntity>(ActionStatus.Ok, entity);

                int apiResult =await _categoryManager.SaveEntityAsync(entity);
                if (apiResult <= 0)
                    result.SetError().AddExceptionMessage($"Unable to save category");
                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.CreateEntityException(typeof(CategoryEntity), entity.Id.ToString());
                return new ActionResult<CategoryEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
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

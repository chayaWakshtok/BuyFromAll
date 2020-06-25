using AM.Common;
using AM.Common.BL;
using AM.Common.Data;
using Entities.Retail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.DataManagers.IDataManager;

namespace BC.TavHaSagol.BO
{
  public  class Brand : IBaseCrud<BrandEntity, int>
    {
        private IBrandManager _brandManager;
        public Brand(IBrandManager brandManager)
        {
            _brandManager = brandManager;
        }
        public async Task<ActionResult<BrandEntity>> DeleteAsync(int key)
        {
            try
            {
                if (key <= 0)
                    throw new ArgumentException("Given key should be greater than zero");
                ActionResult<BrandEntity> result = new ActionResult<BrandEntity>(ActionStatus.Ok);

                int res = await _brandManager.DeleteEntityAsync(key);
                if (res <= 0)
                    result.SetError().AddExceptionMessage($"Unable to delete category id: {key}");
                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.DeleteEntityException(typeof(CategoryEntity), key.ToString());
                return new ActionResult<BrandEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }

        public async Task<ActionResult<List<BrandEntity>>> GetAll()
        {
            try
            {
                List<BrandEntity> list = await _brandManager.GetEntitiesAsync();
                return new ActionResult<List<BrandEntity>>(ActionStatus.Ok, list);
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.GetEntityException(typeof(CategoryEntity));
                return new ActionResult<List<BrandEntity>>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }

        public Task<ActionResult<BrandEntity>> FindAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<BrandEntity>> SaveAsync(BrandEntity entity)
        {
            try
            {
                if (entity.Id == 0)
                    throw new ArgumentException("Only entity with id can be saved");

                ActionResult<BrandEntity> result = new ActionResult<BrandEntity>(ActionStatus.Ok, entity);

                int apiResult = await _brandManager.SaveEntityAsync(entity);
                if (apiResult <= 0)
                    result.SetError().AddExceptionMessage($"Unable to save basket");
                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.CreateEntityException(typeof(BrandEntity), entity.Id.ToString());
                return new ActionResult<BrandEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }

        public async Task<ActionResult<BrandEntity>> UpdateAsync(BrandEntity entity)
        {
            try
            {
                ActionResult<BrandEntity> result = new ActionResult<BrandEntity>(ActionStatus.Ok, entity);

                int res = await _brandManager.UpdateEntityAsync(entity);
                if (res <= 0)
                    result.SetError().AddExceptionMessage($"Unable to update BasketEntity id {entity.Id}");

                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.UpdateEntityException(typeof(BrandEntity), entity.Id.ToString());
                return new ActionResult<BrandEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }
    }
}

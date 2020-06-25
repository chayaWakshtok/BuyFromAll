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
    public class Basket : IBaseCrud<BasketEntity, int>
    {
        private IBasketManager _basketManager;
        public Basket(IBasketManager basketManager)
        {
            _basketManager = basketManager;
        }

        public async Task<ActionResult<List<BasketEntity>>> GetAll()
        {
            try
            {
                List<BasketEntity> list = await _basketManager.GetEntitiesAsync();
                return new ActionResult<List<BasketEntity>>(ActionStatus.Ok, list);
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.GetEntityException(typeof(BasketEntity));
                return new ActionResult<List<BasketEntity>>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }
        public async Task<ActionResult<BasketEntity>> DeleteAsync(int key)
        {
            try
            {
                if (key <= 0)
                    throw new ArgumentException("Given key should be greater than zero");
                ActionResult<BasketEntity> result = new ActionResult<BasketEntity>(ActionStatus.Ok);

                int res = await _basketManager.DeleteEntityAsync(key);
                if (res <= 0)
                    result.SetError().AddExceptionMessage($"Unable to delete category id: {key}");
                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.DeleteEntityException(typeof(BasketEntity), key.ToString());
                return new ActionResult<BasketEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }

        public Task<ActionResult<BasketEntity>> FindAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public async Task<ActionResult<BasketEntity>> SaveAsync(BasketEntity entity)
        {
            try
            {
                if (entity.Id == 0)
                    throw new ArgumentException("Only entity with id can be saved");

                ActionResult<BasketEntity> result = new ActionResult<BasketEntity>(ActionStatus.Ok, entity);

                int apiResult = await _basketManager.SaveEntityAsync(entity);
                if (apiResult <= 0)
                    result.SetError().AddExceptionMessage($"Unable to save basket");
                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.CreateEntityException(typeof(BasketEntity), entity.Id.ToString());
                return new ActionResult<BasketEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }

        public async Task<ActionResult<BasketEntity>> UpdateAsync(BasketEntity entity)
        {
            try
            {
                ActionResult<BasketEntity> result = new ActionResult<BasketEntity>(ActionStatus.Ok, entity);

                int res = await _basketManager.UpdateEntityAsync(entity);
                if (res <= 0)
                    result.SetError().AddExceptionMessage($"Unable to update BasketEntity id {entity.Id}");

                return result;
            }
            catch (Exception ex)
            {
                string errMessage = Messages.Error.UpdateEntityException(typeof(BasketEntity), entity.Id.ToString());
                return new ActionResult<BasketEntity>(ActionStatus.Error, null, ex).AddExceptionMessage(errMessage);
            }
        }
    }
}

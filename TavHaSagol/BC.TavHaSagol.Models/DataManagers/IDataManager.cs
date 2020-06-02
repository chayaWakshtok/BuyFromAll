using Entities.Retail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataManagers
{
    public class IDataManager
    {
        public interface IUserManager :
       ICrudManager<UserEntity, int>
        {
            //Task<List<RetailerEntity>> GetRetailersAsync(int start, int count);
            //Task<RetailerEntity> GetRetailerByPhoneAsync(string phone);
        }

        public interface ICityManager :
      ICrudManager<CityEntity, int>
        {
        }
        public interface ISiteManager :
       ICrudManager<SiteEntity, int>
        {
        }
        public interface IColorManager :
      ICrudManager<ColorEntity, int>
        {
        }
        public interface ICustomerManager :
    ICrudManager<ColorEntity, int>
        {
        }

        public interface IVatManager :
    ICrudManager<VatEntity, int>
        {
        }

        public interface IBrandManager :
ICrudManager<BrandEntity, int>
        {
        }

        public interface IMaterialManager :
ICrudManager<MaterialEntity, int>
        {
        }
        public interface IManufacturerManager :
ICrudManager<ManufacturerEntity, int>
        {
        }
        public interface ISizeManager :
ICrudManager<SizeEntity, int>
        {
        }
        public interface ICategoryManager :
ICrudManager<CategoryEntity, int>
        {
        }
        public interface ISubCategoryManager :
ICrudManager<SubCategoryEntity, int>
        {
        }

        public interface IItemManager :
ICrudManager<ItemEntity, int>,
             IEntitiesRelationManager<ItemEntity, IItemChildManager, int, int>
        {
        }
        public interface IItemChildManager :
ICrudManager<ItemChildEntity, int>
        {
        }
        public interface IShippingManager :
ICrudManager<ShippingEntity, int>
        {
        }
        public interface IOrderManager :
ICrudManager<OrderEntity, int>
        {
        }
        public interface IOrderItemManager :
ICrudManager<OrderItemEntity, int>
        {
        }
        public interface IPaymentManager :
ICrudManager<PaymentEntity, int>
        {
        }
        public interface IBasketManager :
ICrudManager<BasketEntity, int>
        {
        }
        public interface IWishListManager :
ICrudManager<WishListEntity, int>
        {
        }
        public interface IFeatureManager :
ICrudManager<FeatureEntity, int>
        {
        }
        public interface IItemFeatureManager :
ICrudManager<ItemFeatureEntity, int>
        {
        }
        public interface ICategoryFeatureManager :
ICrudManager<CategoryFeatureEntity, int>
        {
        }
        public interface ISearchManager :
ICrudManager<SearchEntity, int>
        {
        }
        public interface ISearchFeatureManager :
ICrudManager<SearchFeatureEntity, int>
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
   public class ItemEntity
    {
		public int Id { get; set; }
		public string Barcode { get; set; }
		public int CustomerId { get; set; }
		public CustomerEntity Customer { get; set; }
		public int SiteId { get; set; }
		public SiteEntity Site { get; set; }
		public int BrandId { get; set; }
		public BrandEntity Brand { get; set; }
		public int ManufacturerId { get; set; }
		public ManufacturerEntity Manufacturer { get; set; }
		public List<SubCategoryEntity> SubCategories { get; set; }
		public List<FeatureEntity> Features { get; set; }
	}
}

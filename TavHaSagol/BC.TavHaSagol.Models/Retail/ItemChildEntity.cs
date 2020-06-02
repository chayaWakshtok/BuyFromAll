using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
   public class ItemChildEntity
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Stars { get; set; }
		public int VatId { get; set; }
		public VatEntity Vat { get; set; }
		public double Price { get; set; }
		public double PresentLess { get; set; }
		public int ColorId { get; set; }
		public ColorEntity Color { get; set; }
		public int Count { get; set; }
		public string Barcode { get; set; }
		public int ParentItemId { get; set; }
		public ItemEntity Item { get; set; }
		public double ShippingPrice { get; set; }
		public bool Status { get; set; }
		public string ShippingDescription { get; set; }
		public string ReturnDescription { get; set; }
		public string TimeShipping { get; set; }
		public DateTime CreationDate { get; set; }
		public int UnitsStock { get; set; }
		public int SizeId { get; set; }
		public SizeEntity Size { get; set; }
		public List<ImageEntity> Images { get; set; }
	}
}

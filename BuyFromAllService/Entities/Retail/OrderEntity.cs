using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
   public class OrderEntity
    {

		public int Id { get; set; }
		public int ShippingId { get; set; }
		public ShippingEntity Shipping { get; set; }
		public int UserId { get; set; }
		public UserEntity User { get; set; }
		public double TotalPrice { get; set; }
		public bool Status { get; set; }
		public bool Paid { get; set; }
		public List<OrderItemEntity> OrderItems { get; set; }
		public PaymentEntity Payment { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class OrderItemEntity
    {
		public int Id { get; set; }
		public int OrderId { get; set; }
		public bool Status { get; set; }
		public double Price { get; set; }
		public int Count { get; set; }
		public int ItemChildId { get; set; }
		public ItemChildEntity ItemChild { get; set; }

	}
}

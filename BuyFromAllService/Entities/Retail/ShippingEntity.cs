using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class ShippingEntity
    {
		public int Id { get; set; }
		public string Description { get; set; }
		public bool Status { get; set; }
		public DateTime ShippingDate { get; set; }
		public DateTime CreationDate { get; set; }

	}
}

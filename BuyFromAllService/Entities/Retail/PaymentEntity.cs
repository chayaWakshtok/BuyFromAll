using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class PaymentEntity
    {
		public int Id { get; set; }
		public string TransactionId { get; set; }
		public int OrderId { get; set; }
		public DateTime Date { get; set; }
		public int Type { get; set; }
	}
}

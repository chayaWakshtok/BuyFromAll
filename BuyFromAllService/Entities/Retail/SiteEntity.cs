using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class SiteEntity
    {

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Website { get; set; }
		public List<CustomerEntity> Customers { get; set; }
	}
}

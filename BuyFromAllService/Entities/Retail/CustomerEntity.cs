using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class CustomerEntity
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Description { get; set; }
		public string Image { get; set; }
		public bool Status { get; set; }
		public int Stars { get; set; }
		public DateTime CreationDate { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public List<SiteEntity> Sites { get; set; }

	}
}

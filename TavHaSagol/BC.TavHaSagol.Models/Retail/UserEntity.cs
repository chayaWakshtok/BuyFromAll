using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class UserEntity
    {

		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		public string Tell { get; set; }
		public string Password { get; set; }
		public string Street { get; set; }
		public string HouseNumber { get; set; }
		public int Flat { get; set; }
		public string Code { get; set; }
		public string Fax { get; set; }
		public int CityId { get; set; }
		public CityEntity City { get; set; }
		public List<BasketEntity> Baskets { get; set; }
		public List<WishListEntity> WishLists { get; set; }
	}
}

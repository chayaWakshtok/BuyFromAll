using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class WishListEntity
    {
		public int Id { get; set; }
		public int ItemChildId { get; set; }
		public ItemChildEntity ItemChild { get; set; }
		public int UserId { get; set; }
		public UserEntity User { get; set; }
	}
}

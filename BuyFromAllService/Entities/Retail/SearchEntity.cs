using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class SearchEntity
    {
		public int UserId { get; set; }
		public UserEntity User { get; set; }
		public DateTime DateSearch { get; set; }
		public int Id { get; set; }
		public List<SearchFeatureEntity> SearchFeatures { get; set; }
	}
}

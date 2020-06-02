using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class ItemFeatureEntity
    {
		public string Value { get; set; }
		public int FeatureId { get; set; }
		public int ItemId { get; set; }
		public ItemEntity Item { get; set; }
		public int Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class SearchFeatureEntity
    {
		public int SearchId { get; set; }
		public int FeatureId { get; set; }
		public FeatureEntity Feature { get; set; }
		public int Id { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
   public class ImageEntity
    {

		public int Id { get; set; }
		public string ImageSrc { get; set; }
		public string ImageUrl { get; set; }
		public int ItemChildId { get; set; }
	}
}

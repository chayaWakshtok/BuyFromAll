using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Retail
{
    public class CategoryFeatureEntity
    {
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; }
        public string Value { get; set; }
        public int FeatureId { get; set; }
        public int Id { get; set; }
    }
}

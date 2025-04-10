using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabats.RepositoryLayer.Entities
{
    public class Product: BaseEntities
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int? productBrandId { get; set; }
        public ProductBrand productBrand { get; set; }
        public int? productTypeId { get; set; }
        public ProductType productType { get; set; }

    }
}

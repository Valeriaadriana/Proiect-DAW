using System.Collections.Generic;
using DAWProject.Models.Base;

namespace DAWProject.Models
{
    public class ProductType: BaseEntity
    {
        public string Name { get; set; }
        public bool Perishable { get; set; }

        public List<Product> Products { get; set; }
    }
}
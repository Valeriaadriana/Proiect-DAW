using System;
using System.Collections.Generic;
using DAWProject.Models.Base;

namespace DAWProject.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public Guid? ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        
        public List<OrderProduct> Orders { get; set; }
    }
}
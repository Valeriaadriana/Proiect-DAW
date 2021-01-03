using System;
using System.Collections.Generic;
using DAWProject.Models.Base;
using Newtonsoft.Json;

namespace DAWProject.Models
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public Guid? ProductTypeId { get; set; }
        [JsonIgnore]
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        
        [JsonIgnore]
        public List<OrderProduct> Orders { get; set; }
    }
}
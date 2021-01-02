using System.Collections.Generic;
using DAWProject.Models.Base;

namespace DAWProject.Models
{
    public class DeliveryType: BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
using System;
using System.Collections.Generic;
using DAWProject.Models.Base;

namespace DAWProject.Models
{
    public class Order: BaseEntity
    {
        public double Total { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Invoice Invoice { get; set; }
        public Guid? DeliveryTypeId { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<OrderProduct> Products { get; set; }
    }
}
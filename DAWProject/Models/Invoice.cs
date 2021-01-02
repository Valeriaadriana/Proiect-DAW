using System;
using DAWProject.Models.Base;

namespace DAWProject.Models
{
    public class Invoice: BaseEntity
    {
        public int InvoiceNumber { get; set; }
        public double OrderValue { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
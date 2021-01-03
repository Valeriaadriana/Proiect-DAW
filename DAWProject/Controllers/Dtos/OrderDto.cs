using System;
using System.Collections.Generic;

namespace DAWProject.Controllers.Dtos
{
    public class OrderDto : BaseDto
    {
    public double Total { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DeliveryTypeDto DeliveryType { get; set; }
    public List<ProductDto> Products { get; set; }
    public Guid UserId { get; set; }
    }


}
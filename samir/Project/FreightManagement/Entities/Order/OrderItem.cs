using FreightManagement.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreightManagement.Entities.Order
{
    public class OrderItem: BaseEntity
    {
        private string Description { get; set; }
        private Quantity Quantity { get; set; }
    }
}

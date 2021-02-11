using System;
using FreightManagement.Entities.Customers;

namespace FreightManagement.Entities.Order
{
    public class Order
    {
        private Customer Customer { get; set;}
        private DateTime OrderDate { get; set; }
    }
}

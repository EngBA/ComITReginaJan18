using FreightManagement.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreightManagement.Entities.Customers
{
    public class Location : BaseEntity
    {
        private Address deliveryAddress { get; set; }
        private Address billingAddress { get; set; }
        private ICollection<LocationTank> tanks { get; set; }
    }
}

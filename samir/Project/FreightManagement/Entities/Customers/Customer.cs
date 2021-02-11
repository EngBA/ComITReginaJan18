using FreightManagement.ValueObj;
using System.Collections.Generic;

namespace FreightManagement.Entities.Customers

{
   public class Customer : BaseEntity
    {
        public CustomerContract Contract { get; set; }
        private List<Location> _locations;
        private Address _billingAddress;

    }
}

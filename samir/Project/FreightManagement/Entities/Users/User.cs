using System;
using System.Collections.Generic;
using System.Text;
using FreightManagement.ValueObj;

namespace FreightManagement.Entities
{
    class User: BaseEntity
    {
        public Name Name { get; set; }
        
        public Email Email{ get; set; }


    }
}

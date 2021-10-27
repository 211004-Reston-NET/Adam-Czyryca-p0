using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class Manager
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailPhone { get; set; }
        public int Store { get; set; }

        public virtual Store StoreNavigation { get; set; }
    }
}

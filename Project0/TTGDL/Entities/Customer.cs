﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailPhone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

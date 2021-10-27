using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class Store
    {
        public Store()
        {
            LineItems = new HashSet<LineItem>();
            Managers = new HashSet<Manager>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

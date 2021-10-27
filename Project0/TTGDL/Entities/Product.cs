﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TTGDL.Entities
{
    public partial class Product
    {
        public Product()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public string Catagory { get; set; }

        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}

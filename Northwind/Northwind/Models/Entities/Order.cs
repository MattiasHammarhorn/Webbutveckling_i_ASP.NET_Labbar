using System;
using System.Collections.Generic;

namespace Northwind.Models.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? ShippedDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}

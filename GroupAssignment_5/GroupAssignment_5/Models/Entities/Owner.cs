using System;
using System.Collections.Generic;

namespace GroupAssignment_5.Models.Entities
{
    public partial class Owner
    {
        public Owner()
        {
            Car = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Car { get; set; }
    }
}

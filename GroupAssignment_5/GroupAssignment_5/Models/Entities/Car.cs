using System;
using System.Collections.Generic;

namespace GroupAssignment_5.Models.Entities
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
    }
}

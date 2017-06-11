using System;
using System.Collections.Generic;

namespace Tenta.Models.Entities
{
    public partial class Computers
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
    }
}

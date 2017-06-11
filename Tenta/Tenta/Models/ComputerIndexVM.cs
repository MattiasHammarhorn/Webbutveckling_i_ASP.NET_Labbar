using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tenta.Models
{
    public class ComputerIndexVM
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public bool IsExclusiveComputer { get; set; }
    }
}

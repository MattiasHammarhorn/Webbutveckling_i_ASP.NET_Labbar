using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L2_2.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public Address CompanyAddress { get; set; }
        public int EmployeeCount { get; set; }
    }
}

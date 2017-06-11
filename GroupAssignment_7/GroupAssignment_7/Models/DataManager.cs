using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_7.Models
{
    public class DataManager
    {
        public static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "The Galactic Empire", City = "The Death Star" },
            new Customer { Id = 2, Name = "Shinra Electric Power Company", City = "Midgar" },
            new Customer { Id = 3, Name = "Comic Market Preparatory Committee", City = "Tokyo" }
        };

        public static CustomersIndexVM[] CustomersToList()
        {
            return customers.Select(o => new CustomersIndexVM
            {
                Id = o.Id,
                Name = o.Name,
                City = o.City
            }).ToArray();
        }

        public static CustomersIndexVM GetCustomerVM(int id)
        {
            var customer = customers.SingleOrDefault(o => o.Id == id);
            return new CustomersIndexVM
            {
                Id = customer.Id,
                Name = customer.Name,
                City = customer.City
            };
        }
    }
}

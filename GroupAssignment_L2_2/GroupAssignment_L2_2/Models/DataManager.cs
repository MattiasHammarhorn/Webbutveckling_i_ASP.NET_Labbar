using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static GroupAssignment_L2_2.Models.Customer;

namespace GroupAssignment_L2_2.Models
{
    public class DataManager
    {
        private static List<Customer> customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                CompanyName = "Shinra Electric Power Company",
                EmployeeCount = 250000,
                CompanyAddress = new Address
                {
                    Street = "Shinra HQ",
                    City = "Midgar",
                    Country = "Midgar Area"
                }
            },
            new Customer
            {
                Id = 2,
                CompanyName = "The Galactic Empire",
                EmployeeCount = 1000000,
                CompanyAddress = new Address
                {
                    Street = "The Imperial Palace",
                    City = "Federal District",
                    Country = "Coruscant"
                }
            }
        };

        internal static void AddCustomer(Customer customer)
        {
            if (customer.Id < 1)
            {
                customer.Id = 1;
            }
            else
            {
                customer.Id = customers.Max(x => x.Id) + 1;
            }

            customers.Add(customer);
        }

        public static Customer GetCustomer(int id)
        {
            return customers.SingleOrDefault(c => c.Id == id);
        }

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public static void RemoveCustomer(int id)
        {
            customers.Remove(customers.
                SingleOrDefault(c => c.Id == id));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tenta.Models.Entities
{
    public partial class TentaDbContext
    {
        public TentaDbContext(DbContextOptions<TentaDbContext> options) : base(options)
        {
        }
        public ComputerIndexVM[] GetAllComputers()
        {
            string[] status = { "apple", "mac" };

            return Computers
                .Select(o => new ComputerIndexVM()
                {
                    Id = o.Id,
                    Manufacturer = o.Manufacturer,
                    Price = o.Price,
                    IsExclusiveComputer = true ? status.Contains(o.Manufacturer.ToLower()) : false,
                })
                .ToArray();
        }
        public void SaveComputer(ComputerCreateVM vModel)
        {
            var newComputer = new Computers()
            {
                Manufacturer = vModel.Manufacturer,
                Price = vModel.Price,
            };

            Computers.Add(newComputer);
            SaveChanges();
            /*
            Computers.Add(
                new Computers() {
                    Manufacturer = vModel.Manufacturer,
                    Price = vModel.Price
                }
            );
            SaveChanges();*/
        }

        public ComputerEditVM GetComputer(int id)
        {
            var computer = Computers
                .SingleOrDefault(o => o.Id == id);

            return new ComputerEditVM()
            {
                Id = computer.Id,
                Manufacturer = computer.Manufacturer,
                Price = computer.Price,
            };
        }

        public void EditComputer(ComputerEditVM vModel)
        {
            var computer = Computers
                .SingleOrDefault(o => o.Id == vModel.Id);

            computer.Manufacturer = vModel.Manufacturer;
            computer.Price = vModel.Price;
            SaveChanges();
        }
    }
}

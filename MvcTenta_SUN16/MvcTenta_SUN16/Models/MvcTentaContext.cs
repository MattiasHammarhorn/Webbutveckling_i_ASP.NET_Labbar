using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace MvcTenta_SUN16.Models.Entities
{
    public partial class MvcTentaContext : DbContext
    {
        public MvcTentaContext(DbContextOptions<MvcTentaContext> options)
            :base(options)
        {

        }

        public void AddComputers(ComputersCreateVM model)
        {
            Computers computersToAdd = new Computers
            {
                Manufacturer = model.Manufacturer,
                Price = model.Price
            };

            Computers.Add(computersToAdd);
            SaveChanges();
        }

        public ComputersIndexVM[] ListComputers()
        {
            return this.Computers.Select(o => new ComputersIndexVM
            {
                Id = o.Id,
                Manufacturer = o.Manufacturer,
                Price = o.Price,
                Functioning = o.Manufacturer.Equals("Apple")
            }).ToArray();
        }

        public ComputersEditVM FindComputersForEditById(int id)
        {
            Computers computersToConvert = Computers.Single(o => o.Id == id);
            return new ComputersEditVM
            {
                Id = computersToConvert.Id,
                Manufacturer = computersToConvert.Manufacturer,
                Price = computersToConvert.Price
            };
        }

        public void EditComputers(ComputersEditVM model)
        {
            Computers computersToEdit = Computers.Single(o => o.Id == model.Id);

            if (model.Manufacturer != null) computersToEdit.Manufacturer = model.Manufacturer;
            if (model.Price != null) computersToEdit.Price = model.Price;

            SaveChanges();
        }
    }
}
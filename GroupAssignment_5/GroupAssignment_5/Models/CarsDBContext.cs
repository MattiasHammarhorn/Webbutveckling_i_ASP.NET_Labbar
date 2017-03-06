using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace GroupAssignment_5.Models.Entities
{
    public partial class CarsDBContext : DbContext
    {
        public CarsDBContext(DbContextOptions<CarsDBContext> options) : base(options)
        {

        }

        public void AddCar(CarsCreateVM viewModel)
        {
            Car car = new Car
            {
                Id = Car.Max(c => c.Id) + 1,
                Brand = viewModel.Brand,
                Doors = viewModel.Doors,
                TopSpeed = viewModel.TopSpeed,
            };
            Car.Add(car);

            SaveChanges();
        }

        internal CarsIndexVM[] ListCars()
        {
            return this.Car.
                Select(c => new CarsIndexVM
                {
                    Brand = c.Brand,
                    Doors = c.Doors,
                    TopSpeed = c.TopSpeed,
                    ShowAsFast = c.TopSpeed >= 250
                }).ToArray();
        }
    }
}
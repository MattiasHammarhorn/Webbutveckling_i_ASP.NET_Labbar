using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace TentaPractice.Models.Entities
{
    public partial class TentaPracticeDBContext : DbContext
    {
        public TentaPracticeDBContext(DbContextOptions<TentaPracticeDBContext> options) : base(options)
        {
        }

        public void AddCat(CatsCreateVM model)
        {
            Cat catToAdd = new Cat
            {
                Name = model.Name,
                Anger = model.Anger,
                Weight = model.Weight
            };

            this.Cat.Add(catToAdd);
            this.SaveChanges();
        }

        public CatsIndexVM[] ListCats()
        {
            return this.Cat.Select(o => new CatsIndexVM
            {
                Name = o.Name,
                IsAggresive = o.Anger > 7
            }).
            ToArray();
        }
    }
}
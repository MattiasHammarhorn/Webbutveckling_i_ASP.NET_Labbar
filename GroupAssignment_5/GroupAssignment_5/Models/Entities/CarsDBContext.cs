using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GroupAssignment_5.Models.Entities
{
    public partial class CarsDBContext : DbContext
    {
        public virtual DbSet<Car> Car { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
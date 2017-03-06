using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace Northwind.Models.Entities
{
    public partial class NorthwindContext : DbContext
    {
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_ToCustomer");
            });
        }
    }
}
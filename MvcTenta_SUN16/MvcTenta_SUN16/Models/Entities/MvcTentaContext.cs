using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcTenta_SUN16.Models.Entities
{
    public partial class MvcTentaContext : DbContext
    {
        public virtual DbSet<Computers> Computers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computers>(entity =>
            {
                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
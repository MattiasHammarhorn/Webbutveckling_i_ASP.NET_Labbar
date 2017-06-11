using Microsoft.EntityFrameworkCore;
using System;

namespace Tenta.Models.Entities
{
    public partial class TentaDbContext : DbContext
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

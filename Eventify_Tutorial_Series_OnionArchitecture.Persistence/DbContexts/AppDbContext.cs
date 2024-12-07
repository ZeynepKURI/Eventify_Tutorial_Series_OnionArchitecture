using System;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.Comman;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventify_Tutorial_Series_OnionArchitecture.Persistence.DbContexts
{
	public class AppDbContext : DbContext
	{
		public DbSet<Event> Events { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        modelBuilder.Entity<Event>().OwnsOne(x=> x.location);
            base.OnModelCreating(modelBuilder);
        }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventifyDb");
        }


        // Intercaption ( asıl metod çalışmadan önce araya girmek.
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var data = ChangeTracker.Entries<EntityBase>();   // Hepsi entitybaseden türediği için onu aldık.
            foreach ( var entry in data )                             
            {
                if (entry.State == EntityState.Added)                // eğer datetime yeni eklenmişse ekliyoruz
                    entry.Entity.CreatedDate = DateTime.UtcNow;

                else if (entry.State == EntityState.Modified)         // eğer datetime güncellenmişse güncelliyoruz.
                    entry.Entity.UpdatedDate = DateTime.UtcNow;
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}


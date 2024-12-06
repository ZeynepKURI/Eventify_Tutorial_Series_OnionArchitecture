using System;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventify_Tutorial_Series_OnionArchitecture.Persistence.DbContexts
{
	public class AppDbContext : DbContext
	{
		public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventifyDb");
        }
    }
}


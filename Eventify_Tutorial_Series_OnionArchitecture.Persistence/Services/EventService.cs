using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTO;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs;
using Eventify_Tutorial_Series_OnionArchitecture.Application.RequestParameters;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.Entities;
using Eventify_Tutorial_Series_OnionArchitecture.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Eventify_Tutorial_Series_OnionArchitecture.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _context; 

        public EventService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateEventAsync(CreateEventDTO createEventDTO)
        {
            if(createEventDTO is not null)

            {
                var newEvent = new Event()
                {
                    Title = createEventDTO.Title,
                    Date = createEventDTO.Date,
                    location = createEventDTO.location,

                };
                await _context.Events.AddAsync(newEvent);

                await _context.SaveChangesAsync();
            }
           else
                throw new NullReferenceException();
        }

        public async Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination)
        {
            return await _context.Events.AsNoTracking().Select(x=> new EventDTO()
            {
                
                Title = x.Title,
                Date = x.Date,
                location = x.location,

             })
                .Skip(pagination.PageCount=pagination.ItemCount)
                .Take(pagination.ItemCount)
                .ToListAsync();

        }
    }
}


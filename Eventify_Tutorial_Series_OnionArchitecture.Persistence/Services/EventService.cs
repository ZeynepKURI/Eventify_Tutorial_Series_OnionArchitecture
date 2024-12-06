using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTO;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs;
using Eventify_Tutorial_Series_OnionArchitecture.Application.RequestParameters;

namespace Eventify_Tutorial_Series_OnionArchitecture.Persistence.Services
{
    public class EventService : IEventService
    {
        public Task CreateEventAsync(CreateEventDTO createEventDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination)
        {
            throw new NotImplementedException();
        }
    }
}


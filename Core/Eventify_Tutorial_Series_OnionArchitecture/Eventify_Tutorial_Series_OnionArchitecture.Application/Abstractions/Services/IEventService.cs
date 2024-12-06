using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTO;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.Entities;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.ValueObjects;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services
{
	public interface IEventService
	{
		Task CreateEventAsync(CreateEventDTO createEventDTO);

		Task<IEnumerable<Event>> GetAllEventsAsync();
	}
}


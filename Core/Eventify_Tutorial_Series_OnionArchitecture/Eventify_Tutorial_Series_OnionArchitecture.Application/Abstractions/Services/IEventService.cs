using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTO;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs;
using Eventify_Tutorial_Series_OnionArchitecture.Application.RequestParameters;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.Entities;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.ValueObjects;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services
{
	public interface IEventService
	{
		Task CreateEventAsync(CreateEventDTO createEventDTO);  //DTO kullanarak kullanımı kolaylaştırdı aksi takdırde "string Title, DataTimeOffset date , Location location "u yazacaktık.

		Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination);
	}
}


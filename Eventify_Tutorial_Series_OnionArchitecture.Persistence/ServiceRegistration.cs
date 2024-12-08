using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services;
using Eventify_Tutorial_Series_OnionArchitecture.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series_OnionArchitecture.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection service)
		{
			service.AddScoped<IEventService, EventService>();
		}
	}
}


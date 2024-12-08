using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application
{
	public static class ServiceRegistration
	{
		public static void AddApplicationServices(this IServiceCollection service)
		{
			service.AddScoped<ExportService>();
		}
	}
}
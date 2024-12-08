using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services.Concrete;
using Eventify_Tutorial_Series_OnionArchitecture.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Eventify_Tutorial_Series_OnionArchitecture.Infrastructure
{
	public static class ServiceRegistration
	{
        public static void AddApplicationServices(this IServiceCollection service)
        {
            service.AddScoped<IFileService, FileService>();
            service.AddScoped<ITextService ,TextService>();

        }
    }
}


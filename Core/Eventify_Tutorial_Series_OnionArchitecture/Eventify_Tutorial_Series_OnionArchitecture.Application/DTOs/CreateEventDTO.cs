using System;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.ValueObjects;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application.DTO
{
	public class CreateEventDTO
	{
		public string Title { get; set; }

        public DateTimeOffset Date { get; set; }

        public Location location{ get; set; }



       
    }
}


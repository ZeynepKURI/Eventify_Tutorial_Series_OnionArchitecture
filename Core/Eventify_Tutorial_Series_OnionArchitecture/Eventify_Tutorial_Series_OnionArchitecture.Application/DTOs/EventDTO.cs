using System;
using Eventify_Tutorial_Series_OnionArchitecture.Domain.ValueObjects;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs
{
	public class EventDTO
	{
        public string Title { get; set; }


        public DateTimeOffset Date { get; set; }

        public Location location { get; set; }

        // Presentation da kullanıcak veriler dış dünyaya açılacak
    }
}


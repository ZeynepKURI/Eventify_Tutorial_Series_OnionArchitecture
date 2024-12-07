using System;
using System.Text;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs;

namespace Eventify_Tutorial_Series_OnionArchitecture.Infrastructure.Services
{
    public class TextService : ITextService
    {
        public string FormatTextForEvent(IEnumerable<EventDTO> eventItems)
        {
            if (eventItems == null) 
                throw new ArgumentNullException(nameof(eventItems));

            StringBuilder stringBuilder = new();
            foreach (var eventItem in eventItems)
            { 

              if (eventItem is not null)
                stringBuilder.AppendLine($"Event: {eventItem.Title} - Location: {eventItem.location} - Date: {eventItem.Date:HH:mm - dd/MM/yyyy}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}

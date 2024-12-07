using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services
{
	public class ITextService
	{
		string FormatTextForEvent(IEnumerable<EventDTO> eventItems); // Kaydetmek istediğimiz Eventleri istediğimiz gibi formatlandırıp string olarak geri döndürüyoruz
	}
}


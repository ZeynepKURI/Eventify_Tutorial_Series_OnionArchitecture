using System;
namespace Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services
{
	public interface IFileService
	{
		Task SaveTextAsync(string text, string path); // İlk parametre kaydedeceğimiz text; ikinci parametre ise bu textin nereye kaydedeciğini ifade eder.
	}
}


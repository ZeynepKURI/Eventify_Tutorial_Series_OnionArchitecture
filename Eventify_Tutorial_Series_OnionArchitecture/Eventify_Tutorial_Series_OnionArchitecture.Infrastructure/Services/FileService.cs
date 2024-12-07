using System;
using Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services;

namespace Eventify_Tutorial_Series_OnionArchitecture.Infrastructure.Services
{
    public class FileService : IFileService
    {
        public async Task SaveTextAsync(string text, string path)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                    throw new ArgumentNullException(nameof(path));
                await File.WriteAllTextAsync( path, text);
            }


            catch (Exception ex)

            {
                Console.WriteLine($"An error occurred while saving the text to file:{ex.Message}");
            }




        }

    }
}
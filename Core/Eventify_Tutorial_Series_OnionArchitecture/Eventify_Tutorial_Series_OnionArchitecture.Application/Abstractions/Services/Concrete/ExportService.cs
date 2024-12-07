using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Eventify_Tutorial_Series_OnionArchitecture.Application.DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace Eventify_Tutorial_Series_OnionArchitecture.Application.Abstractions.Services.Concrete
{

    // Bu kodun amacı, bir dizi etkinlik (eventItems) bilgisini alıp, belirli bir formatta bir dosya olarak belirli bir konuma kaydetmektir. İşlevsel olarak, etkinlik verilerini bir metin formatında dışa aktarmayı sağlar.
    // Kodun Amacı ve İşlevi Bağımlılıkları Yönetmek:Kodda Dependency Injection(DI) kullanılarak ITextService ve IFileService bağımlılıkları dışarıdan sağlanır.Bu, kodun esnekliğini artırır ve test edilebilirliği sağlar.
//ITextService: Etkinlik verilerini(eventItems) belirli bir formatta metin haline getirir.
//IFileService: Formatlanmış metni belirtilen bir dosya yoluna kaydeder.

    public class ExportService
	{
		private readonly ITextService _textService;
		private readonly IFileService _fileService;

        public ExportService(ITextService textService, IFileService fileService)
        {
            _textService = textService;
            _fileService = fileService;

        }
        public async Task ExportEventsAsync(IEnumerable<EventDTO> eventItems, string path)
        {
            var formattedText = _textService.FormatTextForEvent(eventItems);

                await _fileService.SaveTextAsync(formattedText, path);
        }
    }
}


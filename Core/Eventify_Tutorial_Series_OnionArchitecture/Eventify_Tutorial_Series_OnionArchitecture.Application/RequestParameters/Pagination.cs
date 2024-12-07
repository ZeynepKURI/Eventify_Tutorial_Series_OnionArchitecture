using System;
namespace Eventify_Tutorial_Series_OnionArchitecture.Application.RequestParameters
{

	//SAYFALANDIRMA
	public class Pagination
	{
		public int ItemCount { get; set; } = 5;  //Görüntelenecek 5 veri
		public int PageCount { get; set; } = 0; // Sayfa Belirmek için

    }
}


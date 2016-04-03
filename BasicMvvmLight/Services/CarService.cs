using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BasicMvvmLight.Models;

namespace BasicMvvmLight.Services
{
	public class CarService: ICarService
	{
		public CarService ()
		{
		}

		public Task<IEnumerable<Car>> Load ()
		{
			throw new NotImplementedException ("No cars yet");
		}

		public string GetTopBrand ()
		{
			return "Tesla";
		}
	}
}


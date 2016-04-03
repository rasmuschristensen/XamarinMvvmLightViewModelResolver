using System;
using System.Threading.Tasks;
using System.Collections;
using BasicMvvmLight.Views;
using System.Collections.Generic;
using BasicMvvmLight.Models;

namespace BasicMvvmLight.Services
{
	public interface ICarService
	{
		Task<IEnumerable<Car>> Load ();

		string GetTopBrand ();
	}
}


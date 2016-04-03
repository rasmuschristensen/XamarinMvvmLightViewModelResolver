using System;
using GalaSoft.MvvmLight;

namespace BasicMvvmLight.ViewModels
{
	public class CarViewModel : ViewModelBase
	{
		public CarViewModel ()
		{			
			Brand = "Tesla";
		}

		public string Brand {
			get;
			set;
		}
	}
}


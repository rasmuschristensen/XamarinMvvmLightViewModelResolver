using System;
using System.Reflection;
using System.Linq;
using Microsoft.Practices.ServiceLocation;

namespace BasicMvvmLight.Bootstrap
{
	public class ViewModelResolver
	{
		public ViewModelResolver ()
		{
		}

		public object Resolve (string viewModelName)
		{

			var vmtype = this.GetType ()
				.GetTypeInfo ()
				.Assembly
				.DefinedTypes
				.FirstOrDefault (t => t.Name.Equals (viewModelName))
				.AsType ();

			return ServiceLocator.Current.GetInstance (vmtype);
		}
	}
}



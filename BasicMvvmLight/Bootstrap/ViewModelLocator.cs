using BasicMvvmLight.ViewModels;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Ioc;
using System.Dynamic;

namespace BasicMvvmLight.Bootstrap
{
	public class ViewModelLocator : DynamicObject
	{
		static ViewModelResolver _resolver;

		public ViewModelLocator ()
		{
			ServiceLocator.SetLocatorProvider (() => SimpleIoc.Default);
				
			SimpleIoc.Default.Register<CarViewModel> ();
		}

		public static ViewModelResolver Resolver {
			get {
				if (_resolver == null) {
					_resolver = new ViewModelResolver ();
				}

				return _resolver;
			}
		}

		public object this [string viewModelName] {
			get {               
				return Resolver.Resolve (viewModelName);
			}
		}

		public override bool TryGetMember (GetMemberBinder binder, out object result)
		{
			result = this [binder.Name];
			return true;
		}
	}
}


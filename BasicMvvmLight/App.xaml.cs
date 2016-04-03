using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading;
using BasicMvvmLight.Views;

namespace BasicMvvmLight
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();
			// The root page of your application
			MainPage = new NavigationPage (new CarListView ());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


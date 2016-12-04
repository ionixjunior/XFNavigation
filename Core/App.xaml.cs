﻿using Core.Helpers;
using Core.Interfaces;
using Core.Views;
using Xamarin.Forms;

namespace Core
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			DependencyService.Register<INavigationHelper, NavigationHelper>();

			MainPage = new NavigationPage(new Page1View());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

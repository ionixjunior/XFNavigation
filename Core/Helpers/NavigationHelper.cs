using System;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Views;
using Xamarin.Forms;

namespace Core.Helpers
{
	public class NavigationHelper : INavigationHelper
	{
		private bool _isNavigating = false;

		public async Task GotoPage2()
		{
			await Navigate(new Page2View());
		}

		private async Task Navigate(Page page)
		{
			if (_isNavigating)
				return;
			
			_isNavigating = true;
			await Application.Current.MainPage.Navigation.PushAsync(page);

			Device.StartTimer(
				TimeSpan.FromMilliseconds(500), 
				() => _isNavigating = false
			);
		}
	}
}

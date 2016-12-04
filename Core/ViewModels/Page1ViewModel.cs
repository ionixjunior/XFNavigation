using System.Threading.Tasks;
using System.Windows.Input;
using Core.Interfaces;
using Xamarin.Forms;

namespace Core.ViewModels
{
	public class Page1ViewModel : BaseViewModel
	{
		public ICommand GotoPage2Command =>
			new Command(async () => await GotoPage2());

		private async Task GotoPage2()
		{
			await DependencyService.Get<INavigationHelper>().GotoPage2();
		}
	}
}

using Core.ViewModels;
using Xamarin.Forms;

namespace Core.Views
{
	public partial class Page1View : ContentPage
	{
		public Page1View()
		{
			InitializeComponent();
			BindingContext = new Page1ViewModel();
		}
	}
}

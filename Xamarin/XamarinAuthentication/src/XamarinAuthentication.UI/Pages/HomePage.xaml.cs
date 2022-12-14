using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAuthentication.Core.ViewModels.Home;

namespace XamarinAuthentication.UI.Pages
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxContentPagePresentation(WrapInNavigationPage = false)]
	public partial class HomePage : MvxContentPage<HomeViewModel>
	{
		public HomePage()
		{
			this.InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (Application.Current.MainPage is NavigationPage navigationPage) {
				navigationPage.BarTextColor = Color.White;
				navigationPage.BarBackgroundColor = (Color) Application.Current.Resources["PrimaryColor"];
			}
		}
	}
}

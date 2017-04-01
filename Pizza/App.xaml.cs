using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace Pizza
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new PizzaPage();
		}

		protected override void OnStart()
		{
			MobileCenter.Start("ios=203ab9c6-03dd-4b7c-bca5-26c6d0bcdec5;" +
				   "android={Your Android App secret here}",
				   typeof(Analytics), typeof(Crashes));
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

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace DroneLander2
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }
        public App()

        {
            InitializeComponent();

            MainPage = new NavigationPage(new DroneLander2.MainPage());
        }

        protected override void OnStart()
        {
			// Handle when your app starts
			MobileCenter.Start("android=abf45ff2-48b6-4086-af9f-4cf3b36f7c2c;" +
				   "uwp={Your UWP App secret here};" +
				   "ios={Your iOS App secret here}",
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

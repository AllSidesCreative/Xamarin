using Xamarin.Forms;

namespace moshbasic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); //deleting this doesn't seem to matter

            MainPage = new GreetPage();
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

using EscuelasDeportivas.ViewModels;
using FreshMvvm;

using Xamarin.Forms;

namespace EscuelasDeportivas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var contactList = FreshPageModelResolver.ResolvePageModel<ListaDeportesViewModel>();
            var navContainer = new FreshNavigationContainer(contactList);
            MainPage = navContainer;
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

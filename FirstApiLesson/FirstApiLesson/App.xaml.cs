using FirstApiLesson.Services;
using FirstApiLesson.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApiLesson
{
    public partial class App : Application
    {
        public static TodoManager TodoManager { get; set; }
        public App()
        {
            InitializeComponent();
            TodoManager = new TodoManager(new RestService());
            MainPage = new NavigationPage(new TodoListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

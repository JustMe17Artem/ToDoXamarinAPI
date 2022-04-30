using FirstApiLesson.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApiLesson.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            TodoLV.ItemsSource = await App.TodoManager.GetTodoItemModels();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditTodoPage(true)
            {
                BindingContext = new TodoItemModel
                {
                    Id = Guid.NewGuid().ToString()
                }
            });
        }

        private async void TodoLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditTodoPage
            {
                BindingContext = e.SelectedItem as TodoItemModel
            });
        }
    }
}
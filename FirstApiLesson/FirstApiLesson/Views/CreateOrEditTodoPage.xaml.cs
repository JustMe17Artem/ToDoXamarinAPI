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
    public partial class CreateOrEditTodoPage : ContentPage
    {
        bool IsNewItem;
        public CreateOrEditTodoPage(bool isNew = false)
        {
            InitializeComponent();
            IsNewItem = isNew;
        }

        private async void BtnSaveItem_Clicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItemModel)BindingContext;
            await App.TodoManager.SaveItemAsync(todoItem, IsNewItem);
            await Navigation.PopAsync();
        }

        private async void BtnDeleteItem_Clicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItemModel)BindingContext;
            await App.TodoManager.DeleteTodoAsync(todoItem);
            await Navigation.PopAsync();
        }
        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
using FirstApiLesson.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirstApiLesson.Services
{
    public class TodoManager
    {
        IRestService service;

        public TodoManager(IRestService restService)
        {
            service = restService;
        }
        public Task<List<TodoItemModel>> GetTodoItemModels()
        {
            return service.GetTodoItemAsync();
        }

        public Task DeleteTodoAsync(TodoItemModel item) 
        {
            return service.DeleteTodoItemAsync(item);
        }
        public Task SaveItemAsync(TodoItemModel todoItem, bool isNewItem = false)
        {
            return service.SaveTodoItemAsync(todoItem, isNewItem);
        }
    }
}

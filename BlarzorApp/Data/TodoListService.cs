using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class TodoListService
    {
        ToDoListContext context;

        public TodoListService(ToDoListContext context)
        {
            this.context = context;
        }

        public void AddTodo(TodoItem item)
        {

        }

        public Task<List<TodoItem>> GetAll()
        {
            return context.TodoItem.Select(i => new TodoItem { Title = i.Title, IsDone = i.IsDone }).ToListAsync();
        }
    }
}

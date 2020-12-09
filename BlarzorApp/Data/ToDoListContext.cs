using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options) {
            LoadToDoItem();
        }

        public DbSet<TodoItem> TodoItem { get; set; }
        private void LoadToDoItem()
        {
            var list = new List<TodoItem>()
            {
                new TodoItem() {Title = "hong", IsDone = false},
                new TodoItem() {Title = "hong1", IsDone = false},
                new TodoItem() {Title = "hong2", IsDone = false},
                new TodoItem() {Title = "hong3", IsDone = false},
                new TodoItem() {Title = "hong4", IsDone = false},
            };
            TodoItem.AddRange(list);
            this.SaveChanges();
        }
    }
}

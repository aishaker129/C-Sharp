using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp
{
    internal class TodoService
    {
        private List<Todo> todos = new List<Todo>();
        private int counter = 0;

        public void AddTodo(string title)
        {
            todos.Add(new Todo
            {
                Id = counter++,
                Title = title,
                IsCompleted = false
            });
            Console.WriteLine("Todo created successfully..");
        }

        public void ViewTodo()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("Todo not found..");
                return;
            }

            foreach (Todo todo in todos)
            {
                Console.WriteLine($"{todo.Id}. {todo.Title} - {(todo.IsCompleted ? "Done" : "Pending")}");
            }
        }

        public void UpdateTodo(int id, string title)
        {
            Todo todo = todos.FirstOrDefault(t => t.Id == id);
            if(todo != null)
            {
                todo.Title = title;
                Console.WriteLine("Todo updated successfully..");
            }
            else
            {
                Console.WriteLine("Todo not found..");
            }

        }

        public void DeleteTodo(int id)
        {
            Todo todo = todos.FirstOrDefault(t => t.Id == id);
            if(todo != null)
            {
                todos.Remove(todo);
                Console.WriteLine("Todo deleted successfully..");
            }
            else
            {
                Console.WriteLine("Todo not found..");
            }
        }

        public void MarkTodoComplete(int id)
        {
            Todo todo = todos.FirstOrDefault(t => t.Id == id);

            if(todo != null)
            {
                todo.IsCompleted = true;
                Console.WriteLine("Todo is completed..");
            }
            else
            {
                Console.WriteLine("Todo not found..");
            }
        }
    }
}

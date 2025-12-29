namespace TodoApp
{
    internal class Program
    {
        
       
            static void Main(string[] args)
            {
                TodoService todoService = new TodoService();
                int choice = 0;

                do
                {
                    Console.WriteLine("Wellcome to Todo Application...");
                    Console.WriteLine("1. Add Todo");
                    Console.WriteLine("2. View Todos");
                    Console.WriteLine("3. Update Todo");
                    Console.WriteLine("4. Delete Todo");
                    Console.WriteLine("5. Mark Todo as Complete");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Todo Title: ");
                            string title = Console.ReadLine();
                            todoService.AddTodo(title);
                            break;
                        case 2:
                            todoService.ViewTodo();
                            break;
                        case 3:
                            Console.Write("Enter Todo ID to Update: ");
                            int updateId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter new Title: ");
                            string newTitle = Console.ReadLine();
                            todoService.UpdateTodo(updateId, newTitle);
                            break;
                        case 4:
                            Console.Write("Enter Todo ID to Delete: ");
                            int deleteId = Convert.ToInt32(Console.ReadLine());
                            todoService.DeleteTodo(deleteId);
                            break;
                        case 5:
                            Console.Write("Enter Todo ID to Mark as Complete: ");
                            int completeId = Convert.ToInt32(Console.ReadLine());
                            todoService.MarkTodoComplete(completeId);
                            break;
                        case 0:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                while (choice != 0);
            }
        
    }
}

using System;
using LifeManeger;

class Program
{
  static void Main(string[] args)
  {
    User user = new User("Tomáš");

    while (true)
    {
      Console.WriteLine("\n=== Life Manager ===");
      Console.WriteLine("1. View profile");
      Console.WriteLine("2. Add task");
      Console.WriteLine("3. Show tasks");
      Console.WriteLine("4. Log sleep");
      Console.WriteLine("5. Spend money");
      Console.WriteLine("6. Exit");
      Console.Write("Choose option: ");

      string input = Console.ReadLine();
      Console.Clear();

      switch (input)
      {
        case "1":
          Console.WriteLine(user.ViewProfile());
          break;

        case "2":
          Console.Write("Enter task description: ");
          string taskDesc = Console.ReadLine();
          user.AddTask(taskDesc);
          Console.WriteLine("Task added.");
          break;

        case "3":
          user.ShowTasks();
          break;

        case "4":
          Console.Write("Sleep start (yyyy-mm-dd hh:mm): ");
          DateTime start = DateTime.Parse(Console.ReadLine());
          Console.Write("Sleep end (yyyy-mm-dd hh:mm): ");
          DateTime end = DateTime.Parse(Console.ReadLine());
          user.LogSleep(start, end);
          break;

        case "5":
          Console.Write("Enter amount to spend: ");
          double amount = double.Parse(Console.ReadLine());
          user.SpendMoney(amount);
          break;

        case "6":
          Console.WriteLine("Goodbye!");
          return;

        default:
          Console.WriteLine("Invalid option. Try again.");
          break;
      }
    }
  }
}

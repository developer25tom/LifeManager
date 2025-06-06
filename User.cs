using System;
using System.Collections.Generic;

namespace LifeManeger
{
  class User
  {
    private string name;
    private List<TaskItem> tasks = new List<TaskItem>();
    private List<SleepEntry> sleepLog = new List<SleepEntry>();
    private Budget budget;

    public User(string name)
    {
      this.name = name;
      budget = new Budget(1000); // default money
    }

    public string ViewProfile()
    {
      return $"Name: {name}\nTasks: {tasks.Count}\nSleep Entries: {sleepLog.Count}\n{budget}";
    }

    public void AddTask(string description)
    {
      tasks.Add(new TaskItem(description));
    }

    public void ShowTasks()
    {
      if (tasks.Count == 0)
      {
        Console.WriteLine("No tasks yet.");
        return;
      }

      for (int i = 0; i < tasks.Count; i++)
      {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
      }
    }

    public void LogSleep(DateTime start, DateTime end)
    {
      try
      {
        sleepLog.Add(new SleepEntry(start, end));
      }
      catch (Exception e)
      {
        Console.WriteLine($"Sleep entry error: {e.Message}");
      }
    }

    public void SpendMoney(double amount)
    {
      if (!budget.Spend(amount))
      {
        Console.WriteLine("Not enough money or invalid amount.");
      }
      else
      {
        Console.WriteLine($"You spent {amount} CZK.");
      }
    }
  }
}

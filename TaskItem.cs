namespace LifeManeger
{
  class TaskItem
  {
    public string Description { get; }
    public bool IsDone { get; private set; }

    public TaskItem(string description)
    {
      Description = description;
      IsDone = false;
    }

    public void MarkDone()
    {
      IsDone = true;
    }

    public override string ToString()
    {
      return IsDone ? $"[X] {Description}" : $"[ ] { Description}";
    }
  }
}
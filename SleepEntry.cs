using System;

namespace LifeManeger
{
  class SleepEntry
  {
    public DateTime Start { get;  }
    public DateTime End { get; }

    public double Duration => (End - Start).TotalHours;

    public SleepEntry(DateTime start, DateTime end)
    {
      if (end <= start)
      {
        throw new ArgumentException("End time must be after start time.");
      }

      Start = start;
      End = end;
    }

    public override string ToString()
    {
      return $"Sleep from {Start} to {End} – {Duration:F1} hours";
    }
  }
}
namespace LifeManeger
{
  class Budget
  {
    private double total;

    public Budget(double startingAmount)
    {
      total = startingAmount;
    }

    public bool Spend(double amount)
    {
      if (amount <= 0) return false;
      if (amount > total) return false;

      total -= amount;
      return true;
    }
    
    public override string ToString()
    {
      return $"Balance: {total:F2} CZK";
    }
  }
}
using System;

namespace theoretical_toast
{
  class Program
  {
    static void Main(string[] args)
    {
      int targetNumber = 100, firstMultiple = 3, secondMultiple = 5;
      for (int currentNumber = 0; currentNumber <= targetNumber; currentNumber++)
      {
        if (currentNumber % firstMultiple == 0 && currentNumber % secondMultiple == 0)
        {
          Console.WriteLine("Fizz Bang");
        }
        else if (currentNumber % firstMultiple == 0)
        {
          Console.WriteLine("Fizz");
        }
        else if (currentNumber % secondMultiple == 0)
        {
          Console.WriteLine("Bang");
        }
        else
        {
          Console.WriteLine(currentNumber);
        }
      }
    }
  }
}

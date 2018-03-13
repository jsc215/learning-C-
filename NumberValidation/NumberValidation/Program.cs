using System;

namespace NumberValidation
{
    class Program
    {
      static void Main(string[] args)
      {
        
        Console.WriteLine("Enter a number between 1 and 10");
        var number = Convert.ToInt32(Console.ReadLine());

          if (number >= 1 && number <= 10)
          {
              Console.WriteLine("valid!");
          }
          else
          {
              Console.WriteLine("invalid number?");
          }
       }
    }
}

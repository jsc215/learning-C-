using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("gimme another number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var maxNumber = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The larger number is" + " " + maxNumber);

        }
    }
}

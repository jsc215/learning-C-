using System;

namespace RadarGun
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the speed Limit?");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What was the speed of the car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            var demeritPoints = (carSpeed - speedLimit) / 5;

            if (demeritPoints > 0 && demeritPoints <= 12)
            {
                Console.WriteLine($"A little fast, demerits:  {demeritPoints}");
            }
            else if (demeritPoints > 12)
            {
                Console.WriteLine($"License suspended! demerits: {demeritPoints}");
            }
            else
            {
                Console.WriteLine("You're a safe driver");
            }

        }
    }
}

using System;

namespace LandscapeOrPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the image width.");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the image height.");
            var height = Convert.ToInt32(Console.ReadLine());

            var picture = (width > height) ? "Landscape" : "Portrait";
            Console.WriteLine("You have a" + " " + picture);

        }
    }
}

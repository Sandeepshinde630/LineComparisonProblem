using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            x1 = 14;
            x2 = 15;
            y1 = 18;
            y2 = 19;
            var distance1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(distance1);

            int x3, x4, y3, y4;
            x3 = 10;
            x4 = 11;
            y3 = 11;
            y4 = 20;
            var distance2 = Math.Sqrt((Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)));
            Console.WriteLine(distance2);
            if (distance1 == distance2)
            {
                Console.WriteLine("Lengths are equal");
            }
            else
            {
                Console.WriteLine("Lengths are not equal");
            }

        }




    }
}
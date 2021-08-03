using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            x1 = 11;
            x2 = 14;
            y1 = 16;
            y2 = 18;
            var distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine(distance);
        }
    }
}
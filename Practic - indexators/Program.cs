using System;

namespace Practic___indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int rangeStart, rangeEnd;
            Console.WriteLine("Please,enter you're start of range");
            rangeStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter you're end of range");
            rangeEnd = int.Parse(Console.ReadLine());
            RangeOfArray.Meaning(rangeStart, rangeEnd);
        }
    }
}

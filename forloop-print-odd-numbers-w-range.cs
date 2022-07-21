using System;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // only print odd numbers from 0 to 20
            for (int counter = 1; counter < 20; counter+= 2)
            {
                Console.WriteLine(counter);
            }

            Console.Read();
        }
    }
}

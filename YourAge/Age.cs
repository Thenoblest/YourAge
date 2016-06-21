using System;

namespace YourAge
{
    internal class Age
    {
        public static void Main(string[] args)
        {
            DateTime newDataTime = DateTime.Now;
            Console.WriteLine("So, today is " + newDataTime);

            Console.Write("Do you smoke a cigarettes?: Y/N");

            Console.ReadKey();
        }
    }
}
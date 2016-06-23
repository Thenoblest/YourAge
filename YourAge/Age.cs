using System;

namespace YourAge
{
    internal class Age
    {
        public static void Main()
        {
            DateTime newDataTime = DateTime.Now;
            Console.WriteLine("So, today is " + "{0}", newDataTime);

            Console.Write("Do you smoke a cigarettes? Y/N: ");
            char Y;            
            while (!char.TryParse(Console.ReadLine(), out Y))
            {
                Console.WriteLine("Pardon? ");
            }

            if ((Y == 'Y') || (Y == 'y'))
            {
                int cigTotal;
                Console.Write("How many cigarettes do you smoke in the day?: ");
                while (!int.TryParse(Console.ReadLine(), out cigTotal))
                {
                    Console.WriteLine("Incorrect format, please try again: ");
                }

                //cost of one cigarette
                float costOneCig = 0.3F;

                float sumTotal = cigTotal * costOneCig;
                Console.WriteLine("You are losing every day: {0:C2}", sumTotal);
                Console.WriteLine("In year: {0:C2}", sumTotal * 365);
                Console.ReadKey();
            }
            else
                //coming soon

                Console.ReadKey();
        }
    }
}
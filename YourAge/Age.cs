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
            char Y = Convert.ToChar(Console.ReadLine());

            if (Char.IsUpper(Y))
            {
                Console.Write("How many cigarettes do you smoke in the day?: ");
                int cigTotal = Convert.ToInt16(Console.ReadLine());
                

                //cost of one cigarettes
                float costOneCig = 0.3F;

                float sumTotal = cigTotal * costOneCig;
                Console.WriteLine("You are losing every day:{0:C2}", sumTotal);
                Console.ReadKey();
            }
            else
                //coming soon

                Console.ReadKey();
        }
    }
}
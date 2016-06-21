using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourAge
{
    class Age
    {
        static void Main(string[] args)
        {
            const int A = 1;
            DateTime newDataTime = DateTime.Now;

            Console.WriteLine("So, today is " + newDataTime);
            Console.Write("Enter your year of birth: ");
            int b = Convert.ToInt16(Console.ReadLine());

            //For the future if there is no available date on the PC.
            //Console.WriteLine("Enter current year:");
            //int c = Convert.ToInt16(Console.ReadLine());

            int c = newDataTime.Year;
            int d = c - b;

            if (b >= A)
            {
                Console.WriteLine("Your: " + d);

                int totalDayNormal = (d * 365);
                Console.WriteLine("You have lived " + "{0}" + " days", totalDayNormal);

                int totalHoursNormal = ((d * 365) * 24);
                Console.WriteLine("You have lived " + "{0}" + " hours", totalHoursNormal);

                int totalMinutesNormal = (((d * 365) * 24) * 60);
                Console.WriteLine("You have lived " + "{0}" + " minutes", totalMinutesNormal);
            }
            else
            {
                Console.WriteLine("Did you born before Jesus?");
                Console.WriteLine("Please enter a real your year of birth:");
                int e = Convert.ToInt32(Console.ReadLine());
                int f = c - e;
                if (e > 1)
                {
                    Console.WriteLine("Your: " + f);

                    int totalDayBad = (f * 365);
                    Console.WriteLine("You have lived " + "{0}" + " days", totalDayBad);

                    int totalHoursBad = ((f * 365) * 24);
                    Console.WriteLine("You have lived " + "{0}" + " hours", totalHoursBad);

                    int totalMinutesBad = (((f * 365) * 24) * 60);
                    Console.WriteLine("You have lived " + "{0}" + " minutes", totalMinutesBad);
                }
                else

                {
                    Console.WriteLine("You're impossible!");
                }
            }
            Console.ReadKey();
        }
    }
}

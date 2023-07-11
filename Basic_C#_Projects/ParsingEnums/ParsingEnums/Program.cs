using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, please enter in the day of the week: ");
                string dayOfWeek = Console.ReadLine();
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayOfWeek);
                if (Enum.IsDefined(typeof(DaysOfTheWeek), dayOfWeek))
                {
                    Console.WriteLine(days);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.  Thank you.");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter an actual day of the week.  Thank you.");
            }
            finally
            {
                Console.ReadLine();
            }

        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday, 
            Saturday,
            Sunday
        }
    }
}

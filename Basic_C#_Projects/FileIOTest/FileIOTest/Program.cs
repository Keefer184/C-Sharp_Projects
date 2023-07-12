using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime current = Convert.ToDateTime(DateTime.Now);
            DateTime future = current.AddHours(num);
            Console.WriteLine("In exactly {0} hours it will be {1}", num, future);

            Console.ReadLine();
        }
    }
}

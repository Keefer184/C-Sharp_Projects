using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> things1 = new List<string>() { "Wears glasses", "has brown hair", "likes to play pool" };
            List<int> things2 = new List<int>() { 234, 985, 184, 2710 };
            Employee<string> employee = new Employee<string>() { things = things1 };
            Employee<int> employeeNums = new Employee<int>() { things = things2 };
            foreach(string thing in employee.things)
            {
                Console.WriteLine(thing);
            }
            foreach(int num in employeeNums.things)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}

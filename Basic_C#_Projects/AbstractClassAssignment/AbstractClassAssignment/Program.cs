using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            Console.ReadLine();

            //calling interface
            IQuittable employee2 = new Employee { firstName = "Goingto", lastName = "Leavehere" };
            employee2.Quit();
            Console.ReadLine();
        }
    }
}

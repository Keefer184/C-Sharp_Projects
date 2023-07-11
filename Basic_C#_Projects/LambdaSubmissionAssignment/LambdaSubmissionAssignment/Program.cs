using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { firstName = "Matt", lastName = "Keefer", empId = 1 });
            empList.Add(new Employee() { firstName = "Mike", lastName = "Keefer", empId = 2 });
            empList.Add(new Employee() { firstName = "Tyler", lastName = "Olson", empId = 3 });
            empList.Add(new Employee() { firstName = "Brady", lastName = "Bennet", empId = 4 });
            empList.Add(new Employee() { firstName = "Andrew", lastName = "Hickerson", empId = 5 });
            empList.Add(new Employee() { firstName = "Ronnie", lastName = "James", empId = 6 });
            empList.Add(new Employee() { firstName = "Joe", lastName = "Mama", empId = 7 });
            empList.Add(new Employee() { firstName = "Daniel", lastName = "Perz", empId = 8 });
            empList.Add(new Employee() { firstName = "Kyle", lastName = "Schniederman", empId = 9 });
            empList.Add(new Employee() { firstName = "Joe", lastName = "Cool", empId = 10 });

            //List<Employee> joeList = new List<Employee>();
            //foreach(Employee emp in empList)
            //{
            //    if(emp.firstName == "Joe")
            //    {
            //        joeList.Add(emp);
            //    }
            //}


            List<Employee> joeList = empList.Where(x => x.firstName.Contains("Joe")).ToList();
            List<Employee> greaterThanFive = empList.Where(x => x.empId > 5).ToList();

            //foreach (Employee emp in greaterThanFive)
            //{
            //    Console.WriteLine(emp.firstName + emp.lastName + emp.empId);
            //}


            //Console.ReadLine();

            







        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class WorkForce
    {
        public List<Employee> Employees { get; set; }

        public void Add(Employee newEmp)
        {
            Employees.Add(newEmp);
        }
        
    }
}

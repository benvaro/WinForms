using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_26_DataGridView
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class Employees: IEnumerable
    {
        List<Employee> employees = new List<Employee>();
        public Employees()
        {
            employees.AddRange(new[]
            {
                new Employee{Id = 1, Name = "Ivan", Salary=8000},
                new Employee{Id = 2, Name = "Olia", Salary=6800},
                new Employee{Id = 3, Name = "Anna", Salary=7200}
            });
        }
        public void Add(Employee e)
        {
            employees.Add(e);
        }

        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
    }
}

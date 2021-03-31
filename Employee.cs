using System;
using System.Collections.Generic;
using System.Text;

namespace Emp_Details
{
    class Employee
    {
        public string name;
        public string Designation;
        private int salary;

        public int GetSalary
        {
            get { return salary; }
            set { salary = value; }
        }

        public void Employee_Details()
        {
            Console.WriteLine("Enter the Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Designation:");
            Designation = Console.ReadLine();
            Console.WriteLine("Enter the Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Employee_Details();
        }
        public void Display_Info()
        {
            Console.WriteLine("name: {0}    ,designation :{1} ,salary :{2} ", name, Designation, salary);
        }

    }
}

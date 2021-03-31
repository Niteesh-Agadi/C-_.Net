using System;

namespace Emp_Details
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] EId = new Employee[3];
            EId[0] = new Employee();
            EId[1] = new Employee();
            EId[2] = new Employee();

            EId[0].Display();
            EId[1].Display();
            EId[2].Display();

            EId[0].Display_Info();
            EId[1].Display_Info();
            EId[2].Display_Info();

        }
    }
}

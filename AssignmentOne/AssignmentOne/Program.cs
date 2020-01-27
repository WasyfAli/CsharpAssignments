using System;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee ID: ");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter DepartMent: ");
            string DepartmentName = Console.ReadLine();
            Employee emp = new Employee(Id, Name, DepartmentName);
            emp.onFired += new Employee.Fired(call);
            Console.WriteLine("======Printing Details=======");
            Console.WriteLine("EMP Id: " +emp.GetId());
            Console.WriteLine("EMP Name: " + emp.GetName());
            Console.WriteLine("EMP DepartMent: " + emp.GetDEpartMentName());
            Console.WriteLine("=============================");
            static void call(string s)
            {
                Console.WriteLine($"{s}");
            }

        }
    }
}

using System;

namespace CsharpAssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new HR(100, "John", "Developer", 8000, 4, DateTime.Parse("01/20/2016" ));
            Console.WriteLine(emp1.salary());
            Employee emp2 = new Developer(102, "Snow", "Developer", 8000, 6, DateTime.Parse("04/18/2014" ));
            Console.WriteLine(emp2.salary());

        }
    }
}

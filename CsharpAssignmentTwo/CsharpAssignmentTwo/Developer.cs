using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAssignmentTwo
{
    public class Developer : Employee
    {
        public Developer(int Id, string Name, string Desg, int expr, int A_s, DateTime J_d) : base(Id, Name, Desg, expr, A_s, J_d)
        {

        }
        public override int salary()
        {
            return GetSal() + (GetExperience() * 2000);
        }
    }
}

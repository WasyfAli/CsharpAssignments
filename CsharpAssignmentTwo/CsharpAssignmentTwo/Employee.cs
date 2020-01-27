using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpAssignmentTwo
{
    public abstract class Employee
    {
        private int Id;
        private string Name;
        private string Designation;
        private int Experience;
        private int Salary;
        private DateTime Joining_date;

        public Employee(int Id,string Name,string Desg,int A_s,int expr,DateTime J_d)
        {
            this.Id = Id;
            this.Name = Name;
            this.Designation = Desg;
            this.Experience = expr;
            this.Salary = A_s;
            this.Joining_date = J_d;
        }
        public int GetSal()
        {
            return this.Salary;
        }
        public int GetExperience()
        {
            return this.Experience;
        }
        public abstract int salary();



    }
}

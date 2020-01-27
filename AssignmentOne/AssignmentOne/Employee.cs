using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne
{
    class Employee
    {
        private int Id;
        private string Name;
        private string DepartmentName;
        public delegate void Fired(String messg);
        public event Fired onFired;

        public Employee(int Id,string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;

        }

        public int GetId()
        {
            onFired("GetId() method is called.");
            return this.Id;
        }
        public string GetName()
        {
            onFired("GetName() method is called.");
            return this.Name;
        }
        public string GetDEpartMentName()
        {
            onFired("GetDepartmentName() method is called.");
            return this.DepartmentName;
        }
        //--------------------------------------------------
    
    }   

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RyanEmployeeWageSystem
{
    [Serializable]
    public abstract class RyanEmployee
    {
        private int basicSalary;
        private string id;
        private string name;

        public RyanEmployee(int basicSalary, string id, string name)
        {
            BasicSalary = basicSalary;
            Id = id;
            Name = name;
        }

        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public abstract string Display();

        public string DisplayParent()
        {
            string data = "Id : " + this.Id + "\nName : " + this.Name + "\nBasic Salary : " + this.BasicSalary + "\n";
            return data;
        }
    }
}
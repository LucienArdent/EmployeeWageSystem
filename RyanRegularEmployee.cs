using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RyanEmployeeWageSystem
{
    [Serializable]
    public class RyanRegularEmployee : RyanEmployee
    {
        private int numOfChildren;

        public RyanRegularEmployee(int basicSalary, string id, string name,int numOfChildren):base(basicSalary, id, name)
        {
            NumOfChildren = numOfChildren;
        }

        public int NumOfChildren { get => numOfChildren; set => numOfChildren = value; }

        public int ChildrenAllowance()
        {
            int allowance = 0;
            if(this.NumOfChildren <= 3)
            {
                allowance = (int)(this.NumOfChildren * (0.2 * base.BasicSalary));
            }
            else
            {
                return allowance = (int)(3 * (0.2 * base.BasicSalary));
            }
            return allowance;
        }

        public int CalculateBonus()
        {
            int result = (int)(base.BasicSalary + ChildrenAllowance());
            return result;
        }
        public override string Display()
        {
            string data = "REGULAR EMPLOYEE\n" + base.DisplayParent() + "Number of children : " +
                this.NumOfChildren + "\nChildren Allowance : " + ChildrenAllowance() + "\nBonus : " + CalculateBonus() + "\n";
            return data;
        }
    }
}
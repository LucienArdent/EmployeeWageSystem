using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RyanEmployeeWageSystem
{
    [Serializable]
    public class RyanTemporaryEmployee : RyanEmployee
    {
        private DateTime endDate;
        private DateTime startDate;

        public RyanTemporaryEmployee(int basicSalary, string id, string name ,DateTime endDate, DateTime startDate):base(basicSalary, id, name)
        {
            EndDate = endDate;
            StartDate = startDate;
            
        }

        public DateTime EndDate { get => endDate; set => endDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }

        public int AttendenceBonus()
        {
            int numOfAttendance = (this.EndDate.Date - this.StartDate.Date).Days;
            int bonus = (int)(numOfAttendance * (0.01 * base.BasicSalary));
            return bonus;
        }

        public int Bonus()
        {
            int bonus = (int)((0.1 * base.BasicSalary) + AttendenceBonus());
            return bonus;
        }

        public override string Display()
        {
            string data = "TEMPORARY EMPLOYEE\n" + base.DisplayParent() + "Start Working Date : "
                + this.StartDate + "\nEnd Working Date : " + this.EndDate + "\nAttendance Bonus : " + AttendenceBonus() + "\nBonus : " + Bonus() + "\n";
            return data;
            
        }
    }
}
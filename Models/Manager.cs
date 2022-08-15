
using TrainingProgram;

namespace TrainingProgram.Models
{
    public class Manager :Employee
    {
        private decimal bonus;

        public Manager(decimal Salary,decimal Bonus) : base(Salary,null) 
        {
            bonus = Bonus;
        }
        public override decimal GetSalary() 
        {
            return salary + bonus;
        }
    }
}


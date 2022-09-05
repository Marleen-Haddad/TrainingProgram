
using TrainingProgram;

namespace TrainingProgram.Models
{
    public class Manager :Employee
    {
        private decimal bonus;

        public Manager(Guid Guid ,decimal Salary,decimal Bonus) : base(Guid,Salary) 
        {
            bonus = Bonus;
        }
        public override decimal GetSalary() 
        {
            return salary + bonus;
        }
    }
}


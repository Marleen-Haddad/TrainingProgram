using TrainingProgram;

namespace TrainingProgram.Models
{
    public class LeadDeveloper : Employee
    {

        public LeadDeveloper(decimal Salary, Manager Manager) :base(Salary, Manager) 
        {
        }

        public override decimal GetSalary()
        {
            return salary;
        }
    }
}


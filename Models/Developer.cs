using TrainingProgram;

namespace TrainingProgram.Models
{
    public class Developer : Employee
    {
        public Developer(decimal Salary ,LeadDeveloper Manager) : base(Salary, Manager)
        {

        }

        public override decimal GetSalary()
        {
            return salary;
        }
    }
}

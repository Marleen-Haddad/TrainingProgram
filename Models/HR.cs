
namespace TrainingProgram.Models
{
    public class HR : Employee
    {
        public HR(decimal Salary ,Manager Manager) : base(Salary,Manager)
        {
        }

        public override decimal GetSalary()
        {
            return salary;
        }
    }
}


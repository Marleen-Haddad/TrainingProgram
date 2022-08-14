
namespace Training_Programm___Week_1.Models
{
    public class HR : Employee
    {
        public HR(double Salary ,Manager Manager) : base(Salary,Manager)
        {
        }

        public override double GetSalary()
        {
            return salary;
        }
    }
}


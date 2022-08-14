
namespace Training_Programm___Week_1.Models
{
    public class Developer : Employee
    {
        public Developer(double Salary ,LeadDeveloper Manager) : base(Salary, Manager)
        {

        }

        public override double GetSalary()
        {
            return salary;
        }
    }
}

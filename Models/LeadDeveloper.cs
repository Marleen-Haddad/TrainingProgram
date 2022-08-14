
namespace Training_Programm___Week_1.Models
{
    public class LeadDeveloper : Employee
    {

        public LeadDeveloper(double Salary, Manager Manager) :base(Salary, Manager) 
        {
        }

        public override double GetSalary()
        {
            return salary;
        }
    }
}


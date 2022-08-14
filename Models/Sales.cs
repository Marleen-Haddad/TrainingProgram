
namespace Training_Programm___Week_1.Models
{
    public class Sales : Employee
    {
        private const double target = 1000;  
        public double preSetTarget { set; private get; }
        public Sales(double Salary, Manager Manager,double PreSetTarget) :base(Salary,Manager)
        {
            preSetTarget = PreSetTarget;
        }
        public override double GetSalary()
        {
            if (preSetTarget == target)
               return salary + (salary * 0.15);
            else
                return salary;
        }

    }
}


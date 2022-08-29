
using TrainingProgram;

namespace TrainingProgram.Models
{
    public class Sales : Employee
    {
        private const double target = 1000;
        public double preSetTarget { set; private get; }
        public Sales(Guid Guid,decimal Salary,double PreSetTarget) :base(Guid,Salary)
        {
            preSetTarget = PreSetTarget;
        }
        public override decimal GetSalary()
        {
            if (preSetTarget == target)
               return (salary + (salary *  Convert.ToDecimal(0.15)));
            else
                return salary;
        }

    }
}


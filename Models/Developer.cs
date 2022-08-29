using TrainingProgram;

namespace TrainingProgram.Models
{
    public class Developer : Employee
    {
        public readonly Guid leadDeveloperGuid;
        public Developer(Guid Guid , decimal Salary ) : base(Guid ,Salary)
        {

        }

    }
}

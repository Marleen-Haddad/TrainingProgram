using TrainingProgram;

namespace TrainingProgram.Models
{
    public class LeadDeveloper : Employee
    {
        public readonly Guid managerGuid;
        public LeadDeveloper(Guid Guid ,decimal Salary, Manager Manager) :base(Guid ,Salary) 
        {
        }

    }
}


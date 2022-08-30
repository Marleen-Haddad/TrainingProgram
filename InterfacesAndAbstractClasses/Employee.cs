
namespace TrainingProgram
{
    public abstract class Employee
    {
        protected decimal salary;
        public readonly Guid guid;
        private Employee? manager;
        public Employee(Guid guid,decimal Salary)
        {
            salary = Salary;
            this.guid = guid;
        }
        public virtual decimal GetSalary() { 
          return salary;
        }
        public void SetManager(Employee? Manager)
        {
            manager = Manager;
        }

    }
}


namespace TrainingProgram
{
    public abstract class Employee
    {
        protected decimal salary;
        private Employee? manager;
        public Employee(decimal Salary, Employee? Manager)
        {
            salary = Salary;
            manager = Manager;
        }

        public abstract decimal GetSalary();
    }
}

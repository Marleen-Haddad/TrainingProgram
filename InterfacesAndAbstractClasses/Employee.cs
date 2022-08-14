
namespace Training_Programm___Week_1
{
    public abstract class Employee
    {
        protected double salary;
        private Employee? manager;
        public Employee(double Salary, Employee? Manager)
        {
            salary = Salary;
            manager = Manager;
        }

        public abstract double GetSalary();
    }
}

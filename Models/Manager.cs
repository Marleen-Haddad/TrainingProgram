
namespace Training_Programm___Week_1.Models
{
    public class Manager :Employee
    {
        public double bonus { set; private get; }

        public Manager(double Salary,double Bonus) : base(Salary,null) 
        {
            bonus = Bonus;
        }
        public override double GetSalary() 
        {
            return salary + bonus;
        }
    }
}


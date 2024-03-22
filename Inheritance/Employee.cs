namespace InheritanceTask
{
    public class Employee
    { 
        readonly decimal salary;
        readonly string name;
        decimal bonus;
        public string Name => name;
        public decimal Salary { get => salary; }
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public virtual void SetBonus(decimal bonus) => this.bonus = bonus;

        public decimal ToPay() => salary + bonus;
    }
}


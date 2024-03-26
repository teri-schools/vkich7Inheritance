namespace InheritanceTask
{
    public class Employee
    {
        // Three private fields
        private string name;
        private decimal salary;
        private decimal bonus;

        // Public property for reading employee's last name
        public string Name
        {
            get { return name; }
        }

        // Public property for reading and setting salary
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Constructor with parameters for name and salary
        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        // Virtual method to set bonus
        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        // Method to calculate total payment
        public decimal ToPay()
        {
            return salary + bonus;
        }
    }

}


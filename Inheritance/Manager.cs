using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class Manager : Employee
    {
        // Private field for the number of clients served by the manager during a month
        private int quantity;

        // Constructor with parameters including clientAmount
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            this.quantity = clientAmount;
        }

        // Redefinition of the SetBonus method
        
        public override void SetBonus(decimal bonus)
        {
            if (quantity > 150)
            {
                // If manager served more than 150 clients, bonus increased by 1000
                base.SetBonus(bonus + 1000);
            }
            else if (quantity > 100)
            {
                // If manager served more than 100 clients, bonus increased by 500
                base.SetBonus(bonus + 500);
            }
            else
            {
                // Otherwise, set bonus as it is
                base.SetBonus(bonus);
            }
        }
    }

}


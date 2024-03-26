using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class SalesPerson : Employee
    {
        // Private field for percent of sales targets plan performance
        private int percent;

        // Constructor with parameters including percent
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
            this.percent = percent;
        }

        // Redefinition of the SetBonus method
        public override void SetBonus(decimal bonus)
        {
            if (percent > 200)
            {
                // If plan performance is more than 200%, bonus is tripled
                base.SetBonus(bonus * 3);
            }
            else if (percent > 100)
            {
                // If plan performance is more than 100%, bonus is doubled
                base.SetBonus(bonus * 2);
            }
            else
            {
                // Otherwise, set bonus as it is
                base.SetBonus(bonus);
            }
        }
    }

}

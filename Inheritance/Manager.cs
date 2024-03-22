﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class Manager : Employee
    {
        readonly int quantity;
        public Manager(string name, decimal salary)
            : base(name, salary)
        {
        }
        public Manager(string name, decimal salary, int clientAmount)
            : base(name, salary)
        {
            this.quantity = clientAmount;
        }
        public override void SetBonus(decimal bonus)
        {
            if ((quantity > 100) && (quantity <= 150))
            {
                base.SetBonus(bonus + 500);
            }
            else if (quantity > 150)
                base.SetBonus(bonus + 1000);
            else base.SetBonus(bonus);
        }
    }

}


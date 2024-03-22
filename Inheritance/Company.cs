using System.Linq;


namespace InheritanceTask
{
    public class Company
    {
        readonly Employee[] employees;
        public Company(Employee[] emp)
        {
            employees = emp;
        }
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            if (employees != null)
            {
                foreach (Employee s in employees)
                    s.SetBonus(companyBonus);
            }
        }
        public decimal TotalToPay()
        {
            decimal tp = 0;
            if (employees != null)
            {
                for (int i = 0; i < employees.Length; ++i)
                    tp += employees[i].ToPay();
            }
            return tp;
        }
        public string NameMaxSalary()
        {
            string res = null;
            if (employees != null)
            {
                res = employees[0].Name;
                decimal tp = employees[0].ToPay();
                for (int i = 1; i < employees.Length; ++i)
                    if (employees[i].ToPay() > tp)
                    {
                        tp = employees[i].ToPay();
                        res = employees[i].Name;
                    }
            }
            return res;
        }
    }

}

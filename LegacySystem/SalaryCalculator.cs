using LegacySystem;

namespace LegacySystems
{
    public static class SalaryCalculator
    {
        public static decimal NetSalaryCalculator(Employee employee)
        {
          
            if (!employee.PayItems.Any())
                return 0;
            var TotalPayItems = employee.PayItems.Sum(x => x.Amount);

            return employee.Hours * employee.Rate + TotalPayItems;
        }
    }
}

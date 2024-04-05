using LegacySystems;
namespace DesignPatterns.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee()
            {
                FullName = "Ahmed Elaraby",
                Hours = 40,
                Rate = 10,
                PayItems = new List<PayItem>()
                {
                    new PayItem() { Name = "Bonus", Amount = 100 , IsDeduction = false },
                    new PayItem() { Name = "Tax", Amount = 50 },
                }
            };
            Employee Emp2 = new Employee()
            {
                FullName = "Ahmed Hossam",
                Hours = 40,
                Rate = 10,
                PayItems = new List<PayItem>()
                {
                    new PayItem(){Name = "Bonus", Amount = 100},
                    new PayItem(){Name = "Tax", Amount = -50},
                }

            };
            Console.WriteLine("=========================Using Legacy System=======================");
            EmployeeAdapter employee1 = new EmployeeAdapter(Emp1);
            EmployeeAdapter employee2 = new EmployeeAdapter(Emp2);

           
            Console.WriteLine($"Employee Ahmed Elaraby NetSalary is : {SalaryCalculator.NetSalaryCalculator(employee1)}");
            Console.WriteLine($"Employee Ahmed Hossam NetSalary is : {SalaryCalculator.NetSalaryCalculator(employee2)}");
            
            Console.WriteLine("=========================New System=======================");

        }
    }
}

namespace DesignPatterns.Adapter
{
    public class Employee
    {
        public string FullName { get; set; }
        public int Hours { get; set; }
        public int Rate { get; set; }
        public IEnumerable<PayItem> PayItems { get; set; }

    }
    public class EmployeeAdapter
    {
        private readonly Employee _employee;
        private readonly IEnumerable<PayItemAdapter> _payItems;
        public EmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems = employee.PayItems.Select(x => new PayItemAdapter(x)).ToList();
        }
        public string FullName => _employee.FullName;
        public int Hours => _employee.Hours;
        public int Rate => _employee.Rate;
        public IEnumerable<PayItemAdapter> PayItems => _payItems;
    }
}

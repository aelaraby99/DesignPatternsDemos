namespace DesignPatterns.Adapter
{
    public class PayItem
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsDeduction { get; set; }
    }
    public class PayItemAdapter
    {
        private readonly PayItem _payItem;

        public PayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public string Name => _payItem.Name;
        public decimal Amount => _payItem.IsDeduction ? _payItem.Amount * -1 : _payItem.Amount;
    }
}

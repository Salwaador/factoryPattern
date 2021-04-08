namespace FactoryPattern.FactoryEngine
{
    public class Invoice
    {
        public int Id { get; set; }
        public int IdPaymentMethod { get; set; }
        public decimal Value { get; set; }
    }
}
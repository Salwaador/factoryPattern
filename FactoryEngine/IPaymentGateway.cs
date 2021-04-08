namespace FactoryPattern.FactoryEngine
{
    public interface IPaymentGateway
    {
         void PaymentGranularity(Invoice invoice);
    }
}
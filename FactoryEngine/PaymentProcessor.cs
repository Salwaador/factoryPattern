namespace FactoryPattern.FactoryEngine
{
    public class PaymentProcessor
    {
        IPaymentGateway gateway = null;

        public void PreparePayment(Invoice invoice)
        {
            PaymentGatewayFactory factory = new PaymentGatewayFactory();
            this.gateway = factory.CreatePaymentGateway(invoice);
            this.gateway.PaymentGranularity(invoice);
        }
    }
}
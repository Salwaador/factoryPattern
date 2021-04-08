using System;

namespace FactoryPattern.FactoryEngine
{
    public class PaymentM2 : IPaymentGateway
    {
        public void PaymentGranularity(Invoice invoice)
        {
             Console.WriteLine("PaymentM2");
        }
    }
}
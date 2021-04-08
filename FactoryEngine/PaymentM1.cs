using System;

namespace FactoryPattern.FactoryEngine
{
    public class PaymentM1 : IPaymentGateway
    {
        public void PaymentGranularity(Invoice invoice)
        {
            Console.WriteLine("PaymentM1");
        }
    }
}
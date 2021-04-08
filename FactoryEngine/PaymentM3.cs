using System;

namespace FactoryPattern.FactoryEngine
{
    public class PaymentM3 : IPaymentGateway
    {
        public void PaymentGranularity(Invoice invoice)
        {
            Console.WriteLine("PaymentM3");
        }
    }
}
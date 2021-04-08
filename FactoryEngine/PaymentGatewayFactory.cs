namespace FactoryPattern.FactoryEngine
{
    public class PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(Invoice invoice)
        {
            IPaymentGateway gateway = null; 
            
            switch (invoice.IdPaymentMethod)
            {
                case (int)PaymentMethodsEnum.PaymentM1:
                    gateway = new PaymentM1();
                    break;
                
                case (int)PaymentMethodsEnum.PaymentM2:
                    gateway = new PaymentM2();
                    break;

                case (int)PaymentMethodsEnum.PaymentM3:
                    gateway = new PaymentM3();
                    break;

                default:
                break;
            }

            return gateway;
        }
    }
}
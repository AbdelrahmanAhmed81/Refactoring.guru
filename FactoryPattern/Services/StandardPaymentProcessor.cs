using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    public class StandardPaymentProcessor : PaymentProcessor
    {
        public override IPayment CreatePaymentMethod()
        {
            return new CreditCard();
        }
    }
}

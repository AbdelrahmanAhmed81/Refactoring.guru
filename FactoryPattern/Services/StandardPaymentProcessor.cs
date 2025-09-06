using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    internal class StandardPaymentProcessor : PaymentProcessor
    {
        protected override IPayment CreatePaymentMethod()
        {
            return new CreditCard();
        }
    }
}

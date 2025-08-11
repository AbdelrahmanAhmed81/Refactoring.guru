using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    internal class ExternalUsersPaymentProcessor : PaymentProcessor
    {
        public override IPayment CreatePaymentMethod()
        {
            return new PayPal();
        }
    }
}

using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    internal class ExternalUsersPaymentProcessor : PaymentProcessor
    {
        protected override IPayment CreatePaymentMethod()
        {
            return new PayPal();
        }
    }
}

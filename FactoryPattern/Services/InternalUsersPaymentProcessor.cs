using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    internal class InternalUsersPaymentProcessor : PaymentProcessor
    {
        protected override IPayment CreatePaymentMethod()
        {
            return new BankTransfer();
        }
    }
}

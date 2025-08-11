using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    internal class InternalUsersPaymentProcessor : PaymentProcessor
    {
        public override IPayment CreatePaymentMethod()
        {
            return new BankTransfer();
        }
    }
}

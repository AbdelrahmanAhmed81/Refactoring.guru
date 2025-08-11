using FactoryPattern.Models;
using FactoryPattern.Services;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userType = "internal";
            decimal price = 50.00m;

            PaymentProcessor paymentProcessor;
            if (userType == "internal")
            {
                paymentProcessor = new InternalUsersPaymentProcessor();
            }
            else if (userType == "external")
            {
                paymentProcessor = new ExternalUsersPaymentProcessor();
            }
            else
            {
                paymentProcessor = new StandardPaymentProcessor();
            }

            IPayment paymentMethod = paymentProcessor.CreatePaymentMethod();
            paymentProcessor.ProcessPayment(paymentMethod , price);

            Console.ReadKey();
        }
    }
}

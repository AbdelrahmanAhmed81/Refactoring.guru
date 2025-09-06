using FactoryPattern.Models;

namespace FactoryPattern.Services
{
    public abstract class PaymentProcessor
    {
        //public void ProcessPayment(string payment , decimal price)
        //{
        //    if (payment == "CreditCard")
        //    {
        //        Console.WriteLine($"Processing Credit Card payment of {price:C}");
        //    }
        //    else if (payment == "PayPal")
        //    {
        //        Console.WriteLine($"Processing PayPal payment of {price:C}");
        //    }
        //    else if (payment == "BankTransfer")
        //    {
        //        Console.WriteLine($"Processing Bank Transfer payment of {price:C}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid payment method.");
        //    }
        //}


        //open/closed principle
        public void ProcessPayment(decimal price)
        {
            IPayment payment = CreatePaymentMethod();
            payment.ProcessPayment(price);
        }

        protected abstract IPayment CreatePaymentMethod();
    }
}
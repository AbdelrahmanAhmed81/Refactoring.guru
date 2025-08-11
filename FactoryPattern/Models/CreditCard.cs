namespace FactoryPattern.Models
{
    public class CreditCard : IPayment
    {
        public void ProcessPayment(decimal price)
        {
            Console.WriteLine($"Processing Credit Card payment of {price:C}");
        }
    }
}
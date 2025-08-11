namespace FactoryPattern.Models
{
    public class PayPal : IPayment
    {
        public void ProcessPayment(decimal price)
        {
            Console.WriteLine($"Processing PayPal payment of {price:C}");
        }
    }
}

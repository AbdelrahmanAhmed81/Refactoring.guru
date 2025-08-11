namespace FactoryPattern.Models
{
    public class BankTransfer : IPayment
    {
        public void ProcessPayment(decimal price)
        {
            Console.WriteLine($"Processing Bank Transfer payment of {price:C}");
        }
    }
}
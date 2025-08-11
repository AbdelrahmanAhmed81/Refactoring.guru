namespace FactoryPattern.Models
{
    public interface IPayment
    {
        void ProcessPayment(decimal price);
    }
}

namespace AspnetCoreMert.Services
{
    public class Calculator18 : ICalculator
    {
        public decimal Calculate(decimal amount)
        {
            return amount+(amount * 8/100);
        }
    }
}

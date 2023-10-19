using Enum_Task.Enums;

namespace Enum_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeCurrency(Currency.TRY, 123.45));
        }

        public static double ChangeCurrency(Currency currency, double azn)
        {
            double newValue;
            switch(currency)
            {
                case Currency.Usd:
                    newValue = azn * 0.59;
                    return newValue;

                case Currency.Eur:
                    newValue = azn * 0.56;
                    return newValue;

                case Currency.TRY:
                    newValue = azn * 16.48;
                    return newValue;

                case Currency.Rub:
                    newValue = azn * 57.35;
                    return newValue;

                default:
                    return -1;
            }
        }
    }
}
using System;
using System.Linq;

namespace CurrencyConverter
{
    public static class ConverterBot
    {
        private static string enteredAmount;
        public static int amount;
        public static string enteredCurrency;
        public static string enteredTargetCurrency;
        enum Currency
        {
            USD,
            EUR,
            RUB
        }
        
        public static void AskForCurrency()
        {
            do
            {
                Console.WriteLine("Please enter amount: "); 
                enteredAmount = Console.ReadLine();
            } while (!AmountValidator(enteredAmount));
            do
            {
                Console.WriteLine("Please enter valid currency (supported currencies: USD, EUR, RUB): "); 
                enteredCurrency = Console.ReadLine();
            } while (!CurrencyValidator(enteredCurrency));
            do
            {
                Console.WriteLine("Please enter valid target currency (supported currencies: USD, EUR, RUB): ");
                enteredTargetCurrency = Console.ReadLine();
            } while (!CurrencyValidator(enteredTargetCurrency) || enteredTargetCurrency == enteredCurrency);
            
        }
        private static bool AmountValidator(string enteredText)
        {
            bool isNumber;
            if (int.TryParse(enteredText, out amount))
            {
                isNumber = true;
            }
            else
            {
                isNumber = false;
            }

            return isNumber;
        }
        private static bool CurrencyValidator(string enteredText)
        {
            bool isValidCurrency;
            if (Enum.GetNames(typeof(Currency)).Contains(enteredText))
            {
                isValidCurrency = true;
            }
            else
            {
                isValidCurrency = false;
            }
            return isValidCurrency;
        }
        public static void PrintResult(Converter converter)
        {
            Console.WriteLine(converter.convertedValue);
        }
    }
}
using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterBot.AskForCurrency();
            var converter = new Converter();
            converter.ConvertValue(ConverterBot.amount, ConverterBot.enteredCurrency, ConverterBot.enteredTargetCurrency);
            converter.BankCommision();
            ConverterBot.PrintResult(converter);
        }
    }
}
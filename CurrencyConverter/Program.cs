using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter usd = new Converter();
            usd.CurrencyAndDenominationSeparator();
            usd.ConvertValue();
            usd.BankCommision();
            usd.PrintResult();
        }
    }
}
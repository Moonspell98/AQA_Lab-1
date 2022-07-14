using System;

namespace CurrencyConverter
{
    public class Converter
    {
        private string enteredValue;
        private string currency;
        private string targetCurrency;
        private int denomination;
        private string[] currencies = {"USD", "EUR", "RUB"};
        private double exchangeRatio;
        private double convertedValue;
        public Converter()
        {
            Console.WriteLine("Please enter denomination and currency (e.g. 1000 USD): ");
            enteredValue = Console.ReadLine();
            Console.WriteLine("Please enter target currency (e.g. EUR): ");
            targetCurrency = Console.ReadLine();
            while (targetCurrency == currency)
            {
                Console.WriteLine("Please select other currency: ");
                targetCurrency = Console.ReadLine();
            }

        }

        public void CurrencyAndDenominationSeparator()
        {
            for (int i = 0; i < currencies.Length; i++)
            {
                if (enteredValue.Contains(currencies[i]))
                {
                    currency = currencies[i];
                    denomination = int.Parse(enteredValue.Substring(0, enteredValue.IndexOf(currencies[i])));
                    break;
                }
            }
        }
        public void PrintResult()
        {
            Console.WriteLine(convertedValue + " " + targetCurrency);
        }

        public void ConvertValue()
        {
            switch (targetCurrency)
            {
                case "USD":
                    if (currency == "RUB")
                    {
                        exchangeRatio = 0.013;
                        break;
                    }

                    if (currency == "EUR")
                    {
                        exchangeRatio = 1.14;
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "EUR":
                    if (currency == "RUB")
                    {
                        exchangeRatio = 0.12;
                        break;
                    }
                    if (currency == "USD")
                    {
                        exchangeRatio = 0.88;
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "RUB":
                    if (currency == "USD")
                    {
                        exchangeRatio = 75.04;
                        break;
                    }
                    if (currency == "EUR")
                    {
                        exchangeRatio = 85.65;
                        break;
                    }
                    else
                    {
                        break;
                    }
                    
            }

            convertedValue = denomination * exchangeRatio;
        }

        public void BankCommision()
        {
            convertedValue = convertedValue - convertedValue * 0.03;
            convertedValue = Math.Round(convertedValue, 2);
        }
    }
}
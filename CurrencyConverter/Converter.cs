using System;

namespace CurrencyConverter
{
    public class Converter
    {
        private double exchangeRatio;
        public double convertedValue;
        public void ConvertValue(int amount, string currency, string targetCurrency)
        {
            switch (currency)
            {
                case "USD":
                    if (targetCurrency == "RUB")
                    {
                        exchangeRatio = ExchangeRatio.usdrub;
                        break;
                    }
                    if (targetCurrency == "EUR")
                    {
                        exchangeRatio = ExchangeRatio.usdeur;
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "EUR":
                    if (targetCurrency == "RUB")
                    {
                        exchangeRatio = ExchangeRatio.eurrub;
                        break;
                    }
                    if (targetCurrency == "USD")
                    {
                        exchangeRatio = ExchangeRatio.eurusd;
                        break;
                    }
                    else
                    {
                        break;
                    }
                case "RUB":
                    if (targetCurrency == "EUR")
                    {
                        exchangeRatio = ExchangeRatio.rubeur;
                        break;
                    }
                    if (targetCurrency == "USD")
                    {
                        exchangeRatio = ExchangeRatio.rubusd;
                        break;
                    }
                    else
                    {
                        break;
                    }
            }
            convertedValue = amount * exchangeRatio;
        }
        public void BankCommision()
        {
            convertedValue -= convertedValue * 0.03;
            convertedValue = Math.Round(convertedValue, 2);
        }
    }
}
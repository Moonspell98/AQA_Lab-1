namespace Arrays_and_collections;

public class NumberValidator
{
    public static int Validate(int minValue, int maxValue, string text)
    {
        bool isValid = false;
        int ParsedResult = 0;
        while (!isValid)
        {
            Console.WriteLine(text);
            try
            {
                ParsedResult = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter valid value");
            }

            if (ParsedResult >= minValue && ParsedResult <= maxValue)
            {
                isValid = true;
            }
        }

        Console.Clear();
        return ParsedResult;
    }

    public static double Validate(double minValue, double maxValue, string text)
    {
        bool isValid = false;
        double ParsedResult = 0;
        while (!isValid)
        {
            Console.WriteLine(text);
            try
            {
                ParsedResult = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter valid value");
            }

            if (ParsedResult >= minValue && ParsedResult <= maxValue)
            {
                isValid = true;
            }
        }

        Console.Clear();
        return ParsedResult;
    }
}
namespace Drivers;

public class NumberChoiceValidator
{
    public static int Validate(int minValue, int maxValue, string text)
    {
        bool IsValid = false;
        int ParsedResult = 0;
        while (!IsValid)
        {
            Console.WriteLine(text);
            try
            {
                ParsedResult = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Number format is wrong");
            }

            if (ParsedResult >= minValue && ParsedResult <= maxValue)
            {
                IsValid = true;
            }
        }

        return ParsedResult;
    }
}
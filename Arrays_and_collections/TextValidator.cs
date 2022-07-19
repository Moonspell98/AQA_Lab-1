using System.Text.RegularExpressions;

namespace Arrays_and_collections;

public class TextValidator
{
    private static string pattern = @"\W|\d";
    public static string Validate(string textMessage)
    {
        bool isValid = false;
        string enteredValue = "";
        var regex = new Regex(pattern);
        while (!isValid)
        {
            Console.WriteLine(textMessage);
            try
            {
                enteredValue = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please, enter valid value");
            }

            if (!regex.IsMatch(enteredValue))
            {
                isValid = true;
            }
        }

        return enteredValue;
    }
}
using System.Text.RegularExpressions;

namespace AppointmentBot
{
    public class NameNormalizer
    {
        static string pattern = @"(\d|\W)";
        public static string Normilize(string name)
        {
            string normalizedName = null;
            var regex = new Regex(pattern);
            string nameWithoutSymbols = regex.Replace(name, "");
            for (int i = 0; i < nameWithoutSymbols.Length; i++)
            {
                if (i == 0)
                {
                    normalizedName = char.ToUpper(nameWithoutSymbols[i]).ToString();
                }
                else
                {
                    normalizedName += char.ToLower(nameWithoutSymbols[i]).ToString();
                }
            }
            return normalizedName;
        }
    }
}
namespace AppointmentBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Person();
            ChatBot.SetNames(user);
            user.FirstName = NameNormalizer.Normilize(user.FirstName);
            user.LastName = NameNormalizer.Normilize(user.LastName);
            ChatBot.SetAppointmentDate(user);
            ChatBot.OutputNames(user);
        }
    }
}
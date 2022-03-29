using System;

namespace AppointmentBot
{
    public class ChatBot
    {
        public static void SetAppointmentDate(Person person)
        {
            var randomUtil = new RandomUtils();
            var dateIsValid = false;
            string enteredDate;
            var date = new DateTime();
            Console.WriteLine("Bot: Please enter today date or date in future(mm/dd/yyyy): ");
            enteredDate = Console.ReadLine();
            DateTime.TryParse(enteredDate, out date);
            while (!dateIsValid)
            {
                if (DateTime.TryParse(enteredDate, out date) && date >= DateTime.Today)
                {
                    dateIsValid = true;
                    person.AppointmentDate = DateTime.Parse(enteredDate);
                }
                else
                {
                    Console.WriteLine("Error: you can not choose date from past or enter invalid date");
                    Console.WriteLine("Bot: Please enter today date or date in future(mm/dd/yyyy): ");
                    enteredDate = Console.ReadLine();
                }
            }
            person.AppointmentDate = person.AppointmentDate.AddHours(randomUtil.RandomHours).AddMinutes(randomUtil.RandomMinutes);
        }
        public static void SetNames(Person person)
        {
            Console.WriteLine("Bot: Please enter your first name: ");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Bot: Please enter your last name: ");
            person.LastName = Console.ReadLine();
        }
        public static void OutputNames(Person person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} appointment date is : {person.AppointmentDate}");
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace AppointmentBot
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private DateTime appointmentDate = new DateTime();
        
        public Person()
        {
            Console.WriteLine("Bot: Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Bot: Please enter your last name: ");
            lastName = Console.ReadLine();
            GetAppointmentDate();
            RemoveSymbols();
            FirstSymToUpper();
        }
        public void FirstSymToUpper()
        {
            string fixedFirstName = null;
            string fixedLastName = null;
            for (int i = 0; i < firstName.Length; i++)
            {
                if (i == 0)
                {
                    fixedFirstName = char.ToUpper(firstName[i]).ToString();
                }
                else
                {
                    fixedFirstName += char.ToLower(firstName[i]).ToString();
                }
            }
            firstName = fixedFirstName;
            for (int i = 0; i < lastName.Length; i++)
            {
                if (i == 0)
                {
                    fixedLastName = char.ToUpper(lastName[i]).ToString();
                }
                else
                {
                    fixedLastName += char.ToLower(lastName[i]).ToString();
                }
            }
            lastName = fixedLastName;
        }
        public void RemoveSymbols()
        {
            string pattern = @"(\d|\W)";
            Regex regex = new Regex(pattern);
            string resultFirstName = regex.Replace(firstName, "");
            firstName = resultFirstName;
            string resultLastName = regex.Replace(lastName, "");
            lastName = resultLastName;
        }
        public void GetAppointmentDate()
        {
            Random random = new Random();
            int hours = random.Next(0, 23);
            int minutes = random.Next(1, 60);
            bool dateIsValid = false;
            while (!dateIsValid)
            {
                Console.WriteLine("Bot: Please enter today date or date in future(mm/dd/yyyy): ");
                appointmentDate = DateTime.Parse(Console.ReadLine());
                if (appointmentDate >= DateTime.Today)
                {
                    dateIsValid = true;
                }
                else
                {
                    Console.WriteLine("Error: you can not choose date from past");
                }
            }
            appointmentDate = appointmentDate.AddHours(hours).AddMinutes(minutes);
        }
        public void OutputNames()
        {
            Console.WriteLine($"{firstName} {lastName} appointment date is : {appointmentDate}");
        }
    }
}
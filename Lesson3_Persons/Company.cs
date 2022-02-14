namespace Lesson3_Persons
{
    public class Company
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public Company(string country, string city, string address, string name)
        {
            Name = name;
            Country = country;
            City = city;
            Address = address;
        }
    }
}
using System;

namespace AddressBook_UC1
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public Double PhoneNumber { get; set; }
        public string Email { get; set; }

        public void displaycontact()
        {
            Console.WriteLine("FirstName:" + this.FirstName + "LastName:" + this.LastName + "Adress:" + this.Adress
                + "City:" + this.City + "State:" + this.State + "ZipCode:" + this.ZipCode + "phone number:" + this.PhoneNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name,Last Name,Adress,City,State,Zip Code,phone Number,Email \n");

            Program objprogram = new Program()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Adress = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine()
            };
            objprogram.displaycontact();
            Console.ReadLine();
        }
    }
}

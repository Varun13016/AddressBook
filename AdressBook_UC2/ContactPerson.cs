using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook_UC2
{
    class ContactPerson
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
        public void AddContact()
        {
            Console.WriteLine("Enter First Name,Last Name,Adress,City,State,Zip Code,phone Number,Email \n");

            ContactPerson objcontact = new ContactPerson()
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
            List<ContactPerson> objList = new List<ContactPerson>();
            objList.Add(objcontact);
            objcontact.displaycontact();
            Console.ReadLine();
        }
    }
}

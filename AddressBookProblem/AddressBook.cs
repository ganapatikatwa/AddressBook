using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        List<Contact> addressbook = new List<Contact>();
       
        public void CreateContact()
        {

            Contact contact = new Contact();
            Console.WriteLine("Enter Fisrt Name");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address Name");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City Name");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State Name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter e mail");
            contact.email = Console.ReadLine();
            addressbook.Add(contact);

        }
        public void AddContact()
        {
            Contact newcontact=new Contact();
            Console.WriteLine("Enter the FirstName");
            newcontact.Firstname = Console.ReadLine();
            foreach(Contact contact in addressbook)
            {
                if(contact.Firstname==newcontact.Firstname)
                {
                    Console.WriteLine("Person with this Name Already Exists");
                    return;
                }
            }
           
            Console.WriteLine("Enter Last Name");
            newcontact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address Name");
            newcontact.Address = Console.ReadLine();
            Console.WriteLine("Enter City Name");
            newcontact.City = Console.ReadLine();
            Console.WriteLine("Enter State Name");
            newcontact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            newcontact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            newcontact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter e mail");
            newcontact.email = Console.ReadLine();
            addressbook.Add(newcontact);

        }
        public void Display()
        {
            foreach(Contact contact in addressbook)
            {
                Console.WriteLine("FirstName--"+contact.Firstname);
                Console.WriteLine("LastName--" + contact.Lastname);
                Console.WriteLine("Address--" + contact.Address);
                Console.WriteLine("City--" + contact.City);
                Console.WriteLine("State--" + contact.State);
                Console.WriteLine("Zip--" + contact.Zip);
                Console.WriteLine("PhoneNumber--" + contact.PhoneNumber);
                Console.WriteLine("Email--" + contact.email);

            }
        }
       
    }
}

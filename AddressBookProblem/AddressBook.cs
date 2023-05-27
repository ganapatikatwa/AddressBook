using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        List<Contact> con= new List<Contact>();
        public void AddContact()
        {
            
            Contact contact= new Contact();
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

        }
       
    }
}

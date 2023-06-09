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

        public void EditContact()
        {
            Console.WriteLine("Enter the FirstName to Edit the Contact");
            string Firstname = Console.ReadLine();
            foreach (Contact contact in addressbook)
            {
                if (contact.Firstname == Firstname)
                {
                    Console.WriteLine("Name Matches Please Enter the details to Edit");
                    Console.WriteLine("Select option to Edit \n1)Lastname\n2)Address\n3)City\n4)State\n5)Zip" +
                        "\n)6)Phone Number\n7)E mail");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch(option)
                    {
                        case 1:
                            Console.WriteLine("Enter Last Name");
                            contact.Lastname = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Address Name");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter City Name");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter State Name");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter Zip Code");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter Phone Number");
                            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter e mail");
                            contact.email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Please Enter Proper Option");
                            break;
                    }
                }
                
            }
            Console.WriteLine("No Contact Details Found");
        }
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter the Number of Contacts to add");
            int num=Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                AddContact();
                Console.WriteLine("----------------");
                num--;
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the FirstName to Edit the Contact");
            string Firstname = Console.ReadLine();
            foreach (Contact contact in addressbook)
            {
                if (contact.Firstname.ToLower() == Firstname.ToLower())
                {
                    addressbook.Remove(contact);
                    Console.WriteLine("Entered Contact is Deleted");
                    return;
                }
            }
            Console.WriteLine("Contact Not Found");
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

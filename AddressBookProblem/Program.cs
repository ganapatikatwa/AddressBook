using System;
namespace AddressBookProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook adBook = new AddressBook();
            while (true)
            {
                
                Console.WriteLine("Enter The Choice \n1)Create Contact\n2)Add Contact\n3)Edit Contact" +
                    "\n4)Delete Contact\n5)Add Multiple Contacts");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        adBook.CreateContact();
                        adBook.Display();
                        break;
                    case 2:
                        adBook.AddContact();
                        adBook.Display();
                        break;
                    case 3:
                        adBook.EditContact();
                        adBook.Display();
                        break;
                    case 4:
                        adBook.DeleteContact();
                        adBook.Display();
                        break;
                    case 5:
                        adBook.AddMultipleContact();
                        adBook.Display();
                        break;
                    default:
                        Console.WriteLine("Select Proper Choice");
                        break;
                }
               
            }
           
        }
    }
}
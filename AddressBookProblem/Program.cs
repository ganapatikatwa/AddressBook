using System;
namespace AddressBookProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            while(true)
            {
                AddressBook adBook = new AddressBook();
                Console.WriteLine("Enter The Choice \n1)Create Contact\n2)Add Contact");
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

                    default:
                        Console.WriteLine("Select Proper Choice");
                        break;
                }
               
            }
           
        }
    }
}
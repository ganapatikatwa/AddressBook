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
                Console.WriteLine("Enter The Choice \n1)Create Contact");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        AddressBook addressBook = new AddressBook();
                        addressBook.AddContact();
                        break;
                    default:
                        Console.WriteLine("Select Proper Choice");
                        break;
                }
               
            }
           
        }
    }
}
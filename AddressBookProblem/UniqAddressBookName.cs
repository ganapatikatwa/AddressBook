using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class UniqAddressBookName
    {
        Dictionary<string, AddressBook> addressbookname = new Dictionary<string, AddressBook>();
       
        public void NewAddressBook()
        {
            AddressBook newaddbook=new AddressBook();
            newaddbook.AddMultipleContact();
            Console.WriteLine("Enter the Name of the Address Book");
            string addname= Console.ReadLine();
            addressbookname.Add(addname, newaddbook);
        }
    }
   
}

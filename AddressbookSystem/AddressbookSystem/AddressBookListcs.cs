using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookSystem
{
    public class AddressBookListcs
    {
        List<ContactDetails> addresslist=new List<ContactDetails>();
        public void Addcontact(ContactDetails contact)
        {
            addresslist.Add(contact);
        }
        public void display()
        {
            foreach (var contact in addresslist)
            {
                Console.WriteLine("firstname"+contact.firstname);
                Console.WriteLine("lastname" + contact.lastname);
                Console.WriteLine("address" + contact.address);
                Console.WriteLine("city" + contact.city);
                Console.WriteLine("state" + contact.state);
                Console.WriteLine("zip" + contact.zip);
                Console.WriteLine("phonenumber" + contact.phonenumber);
                Console.WriteLine("email" + contact.emailid);

            }
        }
    }
}

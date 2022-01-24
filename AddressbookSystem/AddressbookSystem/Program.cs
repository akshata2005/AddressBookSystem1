using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system");
            bool flag = true;
            int option;
            ContactDetails newcontact=new ContactDetails();
            ContactDetails contact1=new ContactDetails();
            AddressBookListcs add=new AddressBookListcs();
            while(flag==true)
            {
                Console.WriteLine("choose option\n1 Create contact\n2 addcontact\n3 exit");
                option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("create contact in the way firstname,lastname,address,city,state,zip,phonenumber,emailid");
                         newcontact=new ContactDetails();//object of class contactdetails
                        {
                            newcontact.firstname = Console.ReadLine();
                            newcontact.lastname = Console.ReadLine();
                            newcontact.address = Console.ReadLine();
                            newcontact.city = Console.ReadLine();
                            newcontact.state = Console.ReadLine();
                            newcontact.zip = Console.ReadLine();
                            newcontact.phonenumber = Console.ReadLine();
                            newcontact.emailid = Console.ReadLine();
                        }
                        break;
                        case 2:
                        {
                            Console.WriteLine("Add contact in specific order");
                            newcontact = new ContactDetails();
                            add = new AddressBookListcs();
                            add.Addcontact(newcontact);
                            newcontact.firstname = Console.ReadLine();
                            newcontact.lastname = Console.ReadLine();
                            newcontact.address = Console.ReadLine();
                            newcontact.city = Console.ReadLine();
                            newcontact.state = Console.ReadLine();
                            newcontact.zip = Console.ReadLine();
                            newcontact.phonenumber = Console.ReadLine();
                            newcontact.emailid = Console.ReadLine();
                            add.display();
                            break;
                        }
                        case 3:
                        flag=false;
                        break;
                        default:
                        Console.WriteLine("Choise should be between 1 and 2");
                        break;
                }
            }

        }
    }
}

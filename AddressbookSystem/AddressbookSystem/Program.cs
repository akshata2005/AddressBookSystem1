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
            while(flag==true)
            {
                Console.WriteLine("choose option\n1 Create contact\n2 Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("create contact in the way firstname,lastname,address,city,state,zip,phonenumber,emailid");
                        ContactDetails contact=new ContactDetails();//object of class contactdetails
                        {
                            contact.firstname = Console.ReadLine();
                            contact.lastname = Console.ReadLine();
                            contact.address = Console.ReadLine();
                            contact.city = Console.ReadLine();
                            contact.state = Console.ReadLine();
                            contact.zip = Console.ReadLine();
                            contact.phonenumber = Console.ReadLine();
                            contact.emailid = Console.ReadLine();
                        }
                        break;
                        case 2:
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

using System.Collections.Generic;
using System.IO;
using static System.Net.WebRequestMethods;

namespace AddressBookSystem
{
    internal class Program
    {
        private static string file;
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");

            Console.WriteLine("choose option 1.create contact \t 2.Add Contact\t 3.fileio");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1CreateContact.CreateContactInAddresssBook();
                    break;
                case 2:
                    UC2AddContact.AddContactInAddresssBook();
                    break;
               /* case 3:
                    FileIO.Serialize( file = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\Contacts.txt", FileMode.Create);
                    Console.WriteLine(file = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\Contacts.txt", FileMode.Create);
                    FileIO.Deserialize(file = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\Contacts.txt", FileMode.Open);
                    Console.WriteLine(file = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\Contacts.txt", FileMode.Open);
                    break;
               */
                case 4:

                default:
                    Console.WriteLine("enter correct choice");
                    break;
            }
        }
    }
}
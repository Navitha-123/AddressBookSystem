using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC2AddContact
    {
        public UC2AddContact(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        {
           
        }

        public static void AddContactInAddresssBook()
        {
            UC2AddContact user1 = new UC2AddContact("navitha", "reddy", "Anantapur", "AP", "515731", "6409765439", "nav123@gmail.com");
            UC2AddContact user2 = new UC2AddContact("vasy", "dev", "Banglore", "Karnataka", "516721", "9567834253", "vasy345@gmail.com");
            UC2AddContact user3 = new UC2AddContact("vinay", "reddy", "hyderabad", "Telangana", "515601", "89564239065", "vainay23@gmail.com");
            UC2AddContact user4 = new UC2AddContact("chinnu", "harsha", "vizag", "AP", "515423", "6435278965", "chinnu@gmail.com");
            UC2AddContact user5 = new UC2AddContact("laksha", "hita", "atmakuru", "AP", "516437", "8976543976", "laksha@gmail.com");
            UC2AddContact user6 = new UC2AddContact("navitha", "reddy", "Anantapur", "AP", "515731", "6409765439", "nav123@gmail.com");

            LinkedList<UC2AddContact> list = new LinkedList<UC2AddContact>();
            list.AddLast(user1);
            list.AddLast(user2);
            list.AddLast(user3);
            list.AddLast(user4);
            list.AddLast(user5);
            list.AddLast(user6);

            foreach (UC2AddContact contact in list)
            {
                Console.WriteLine(contact);
            }

            Console.WriteLine("add a new contact in addressbook");
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("address");
            string address = Console.ReadLine();
            Console.WriteLine("state");
            string state = Console.ReadLine();
            Console.WriteLine("pincode");
            string pincode = Console.ReadLine();
            Console.WriteLine("mobilenumber");
            string mobilenumber = Console.ReadLine();
            Console.WriteLine("email");
            string email = Console.ReadLine();

            
            UC2AddContact user7 = new UC2AddContact("devi", "uma", "gooty", "AP", "515002", "8675423987", "deviu@gmail.com");
            list.AddLast(user7);
            foreach(UC2AddContact contact in list)
            {
                Console.WriteLine(contact);
            }



        }

    }
}


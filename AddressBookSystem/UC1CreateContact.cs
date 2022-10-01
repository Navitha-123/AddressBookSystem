using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC1CreateContact
    {
        public UC1CreateContact(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        {
        }

        public static void CreateContactInAddresssBook()
        {
            UC1CreateContact user1 = new UC1CreateContact("navitha", "reddy", "Anantapur", "AP", "515731", "6409765439", "nav123@gmail.com");
            UC1CreateContact user2 = new UC1CreateContact("vasy", "dev", "Banglore", "Karnataka", "516721", "9567834253", "vasy345@gmail.com");
            UC1CreateContact user3 = new UC1CreateContact("vinay", "reddy", "hyderabad", "Telangana", "515601", "89564239065","vainay23@gmail.com");
            UC1CreateContact user4 = new UC1CreateContact("chinnu", "harsha", "vizag", "AP", "515423", "6435278965", "chinnu@gmail.com");
            UC1CreateContact user5 = new UC1CreateContact("laksha", "hita", "atmakuru", "AP", "516437", "8976543976", "laksha@gmail.com");
            UC1CreateContact user6 = new UC1CreateContact("navitha", "reddy", "Anantapur", "AP", "515731", "6409765439", "nav123@gmail.com");

            LinkedList<UC1CreateContact> list = new LinkedList<UC1CreateContact>();
            list.AddLast(user1);
            list.AddLast(user2);
            list.AddLast(user3);
            list.AddLast(user4);
            list.AddLast(user5);
            list.AddLast(user6);
        
        }

    }
}

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("choose option 1.create contact \t 2.Add Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1CreateContact.CreateContactInAddresssBook();
                    break;
                case 2:
                    UC2AddContact.AddContactInAddresssBook();
                    break;
                default:
                    Console.WriteLine("enter correct choice");
                    break;
            }
        }
    }
}
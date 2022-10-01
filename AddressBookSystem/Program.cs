namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("choose option 1.create contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UC1CreateContact.CreateContactInAddresssBook();
                    break;
                default:
                    Console.WriteLine("enter correct choice");
                    break;
            }
        }
    }
}
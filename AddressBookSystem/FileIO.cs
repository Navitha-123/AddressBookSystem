using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class FileIO
    {
        
        public void Serialize(List<FileIO> list)
        {
            FileStream file = new FileStream(@"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\Contacts.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter(); 
            formatter.Serialize(file, list);    
            file.Close();
        }
        public void Deserialize(string v)
        {
            FileStream fileStream = new FileStream(@"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\Contacts.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            FileIO deserialize = (FileIO)formatter.Deserialize(fileStream);
            Console.WriteLine();

        }
    }
}

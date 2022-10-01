using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
namespace AddressBookSystem
{
    public class ContactUsingCsvFile
    {
        public static void CsvSerialize(List<ContactUsingCsvFile>list)
        {
            string csvFilePath = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\CsvData.txt";
            StreamWriter streamWriter = new StreamWriter(csvFilePath);
            CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords<ContactUsingCsvFile>(list);  
            streamWriter.Close();
            Console.WriteLine("closed");

        }

        public static void CsvDeserialize(List<ContactUsingCsvFile> list)
        {
            string csvFilePath = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\CsvData.txt";
            StreamReader streamReader = new StreamReader(csvFilePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            
            List<ContactUsingCsvFile> ContactUsingCsvFile = csvReader.GetRecords<ContactUsingCsvFile>().ToList();
            foreach (ContactUsingCsvFile contactUsingCsvFile in ContactUsingCsvFile)    
                csvReader.GetRecords(contactUsingCsvFile); 
            streamReader.Close();
            new StreamReader(csvFilePath).Close();  



        }
    }
}

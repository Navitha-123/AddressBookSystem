using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace AddressBookSystem
{
    public class ContactUsingJson
    {
        private static Stream jsonFilePath;
        public static void Serialize(List<ContactUsingCsvFile> list)
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
            string jsonFilePath = @"D:\Users\LENOVO\Desktop\navitha\AddressBookSystem\AddressBookSystem\jsonData.txt";


            StreamReader streamReader = new StreamReader(csvFilePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            List<ContactUsingCsvFile> ContactUsingCsvFile = csvReader.GetRecords<ContactUsingCsvFile>().ToList();
            foreach (ContactUsingCsvFile contactUsingCsvFile in ContactUsingCsvFile)
                csvReader.GetRecords(contactUsingCsvFile);
            streamReader.Close();
            new StreamReader(csvFilePath).Close();



        }
        public static void JsonSerialize(object contactUsingJson)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter stream = new StreamWriter(jsonFilePath))
            using (JsonWriter jsonWriter = new JsonTextWriter(stream))

                jsonSerializer.Serialize(jsonWriter, contactUsingJson);



        } 
    }

       

    
}

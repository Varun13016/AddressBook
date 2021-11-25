﻿using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;



namespace AddressBook_UC15
{

    public class CsvHandler
    {
        public static void ImplementCSVDataHandling()
        {
            string importPath = @"C:\Users\VARUN KUMAR\source\repos\Adress book\AddressBook-UC15\AddressBook-UC15\Demo.csv";
            string exportpath = @"C:\Users\VARUN KUMAR\source\repos\Adress book\AddressBook-UC15\AddressBook-UC15\Demo.json";

            using (var reader = new StreamReader(importPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<addressData>().ToList();
                Console.WriteLine("Read Data Successfully from address.csv");
                foreach (addressData addressData in records)
                {
                    Console.WriteLine("" + addressData.FirstName);
                    Console.WriteLine("" + addressData.LastName);

                    Console.WriteLine("" + addressData.Address);

                    Console.WriteLine("" + addressData.City);

                    Console.WriteLine("" + addressData.State);
                    Console.WriteLine("" + addressData.Code);
                    Console.WriteLine("\n");


                }
                                
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportpath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class DataMahasiswa1302203122
    {
        public static void readJson()
        {
            string jsonString = File.ReadAllText("C:/SEMESTER 4/KONSTRUKSI PERANGKAT LUNAK/PRAKTIKUM6_Versi2/Jurnal-MOD6-KPL/modul6_kelompok_01/jurnal6_1_1302203122.json");
            dynamic data = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine(data.firstName);
            Console.WriteLine(data.lastName);
            Console.WriteLine(data.gender);
            Console.WriteLine(data.age);
            Console.WriteLine(data.address.streetAddress);
            Console.WriteLine(data.address.city);
            Console.WriteLine(data.address.state);
            foreach (var item in data.courses)
            {
                Console.WriteLine(item.code);
                Console.WriteLine(item.name);
            }
        }

    }
}
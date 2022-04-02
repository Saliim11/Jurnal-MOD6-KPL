using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class DataMahasiswa1302204116
    {
        public static void ReadJson()
        {
            string jsonString = File.ReadAllText("C:/RAFI/KULIAH/Semester 4/Kontruksi Perangkat Lunak/Pratikum/Week 6/TP_1302204116/modul6_kelompok_01/jurnal6_1_1302204116.json");
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
}

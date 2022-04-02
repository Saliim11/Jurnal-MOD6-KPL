using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class DataMahasiswa1302200119
    {
        public static void ReadJson()
        {
            string jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/modul6_kelompok_01/modul6_kelompok_01/jurnal6_1_1302200119.json");
            dynamic data = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("First Name\t: " + data.firstName);
            Console.WriteLine("Last Name\t: " + data.lastName);
            Console.WriteLine("Gender\t\t: " + data.gender);
            Console.WriteLine("Age\t\t: " + data.age);
            Console.WriteLine("Street Address\t: " + data.address.streetAddress);
            Console.WriteLine("City\t\t: " + data.address.city);
            Console.WriteLine("State\t\t: " + data.address.state + "\n");
            Console.WriteLine("Courses:");
            foreach (var item in data.courses)
            {
                Console.WriteLine("Code\t\t: " + item.code);
                Console.WriteLine("Name\t\t: " + item.name+"\n");
            }
        }
    }
}

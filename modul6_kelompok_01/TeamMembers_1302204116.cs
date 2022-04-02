using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_01
{
    internal class TeamMembers_1302204116
    {
        public static void ReadJson()
        {
            string jsonString = File.ReadAllText("C:/RAFI/KULIAH/Semester 4/Kontruksi Perangkat Lunak/Pratikum/Week 6/TP_1302204116/modul6_kelompok_01/jurnal6_2_1302204116.json");
            dynamic input = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("Team member list: ");
            foreach (var item in input.members)
            {
                Console.WriteLine("NIM: " + item.nim);
                Console.WriteLine("Nama: " + item.firstName + item.lastName);
                Console.WriteLine("Umur: " + item.age);
                Console.WriteLine("Jenis Kelamin: " + item.gender);
                Console.WriteLine();
            }
        }
    }
}

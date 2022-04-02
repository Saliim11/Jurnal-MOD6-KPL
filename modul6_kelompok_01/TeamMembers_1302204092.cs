using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_01
{
    internal class TeamMembers_1302204092
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:/Users/ASUS/Documents/SE4401/Semester 4/Konstruksi Perangkat Lunak/W6/Praktikum_Baru/Jurnal/Jurnal-MOD6-KPL/modul6_kelompok_01/jurnal6_2_1302204092");

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

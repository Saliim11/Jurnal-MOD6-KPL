using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class TeamMembers1302200119
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/modul6_kelompok_01/modul6_kelompok_01/jurnal6_2_1302200119.json");
            dynamic data = JsonConvert.DeserializeObject(jsonString);

            foreach (var member in data.members)
            {
                Console.WriteLine("First Name\t: " + member.firstName);
                Console.WriteLine("Last Name\t: " + member.lastName);
                Console.WriteLine("Gender\t\t: " + member.gender);
                Console.WriteLine("Age\t\t: " + member.age);
                Console.WriteLine("NIM\t\t: " + member.nim+"\n");
            }
        }
    }
}

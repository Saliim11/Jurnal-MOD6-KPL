using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    internal class TeamMembers1302200089
    {
        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:/Users/Panji/Documents/VS Community things/Jurnal6BARU/Jurnal-MOD6-KPL/modul6_kelompok_01/jurnal6_2_1302200089.json");

            dynamic data = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("Team member list:");
            foreach (var item in data.members)
            {
                Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName+ " " + item.age +" " + item.gender);
                

            }
           
        }
    }
}

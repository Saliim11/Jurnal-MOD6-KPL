using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_01
{
    class DataMahasiswa1302200089
    {
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:/Users/Panji/Documents/VS Community things/Jurnal6BARU/Jurnal-MOD6-KPL/modul6_kelompok_01/jurnal6_1_1302200089.json");

            dynamic mhs = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Nama: \t\t" + mhs.firstName + mhs.lastName);
            Console.WriteLine("Gender: \t" + mhs.gender);
            Console.WriteLine("Age: \t\t" + mhs.age);
            Console.WriteLine("Alamat: \t" + mhs.address.streetAddress);
            Console.WriteLine("City: \t\t" + mhs.address.city);
            Console.WriteLine("State: \t\t" + mhs.address.state);
            Console.WriteLine("Courses: ");

            foreach (var item in mhs.courses)
            {
                Console.WriteLine(item.code + " - " + item.name);
 
            }


        }
    }
}

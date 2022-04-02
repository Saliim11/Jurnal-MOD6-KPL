using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_01
{
    internal class GlossaryItem_1302204092
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:/Users/ASUS/Documents/SE4401/Semester 4/Konstruksi Perangkat Lunak/W6/Praktikum_Baru/Jurnal/Jurnal-MOD6-KPL/modul6_kelompok_01/jurnal6_3_1302204092");

            dynamic input = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine("Gloss Entry: ");
            Console.WriteLine("ID: " + input.glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine("SortAs: " + input.glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine("Acronomy: " + input.glossary.GlossDiv.GlossList.GlossEntry.Acronomy);
            Console.WriteLine("Abbrev: " + input.glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            //Console.WriteLine("Gloss : ");
            //Console.WriteLine("Para: " + input.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            //Console.WriteLine("GlossSeeAlso: " + input.glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso);
            //Console.WriteLine("Gloss See: " + input.glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }
    }
}
